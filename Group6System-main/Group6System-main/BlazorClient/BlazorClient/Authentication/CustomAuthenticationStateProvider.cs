﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BlazorClient.Data.CustomerService;
using BlazorClient.Data.UserService;
using BlazorClient.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;

namespace BlazorClient.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly IUserService _userService;
        private readonly ICustomerService _customerService;

        private User _cachedUser { get; set; }

        public static User storedUser;

        public CustomAuthenticationStateProvider(IJSRuntime jsRuntime, IUserService userService, ICustomerService customerService)
        {
          _jsRuntime = jsRuntime;
          _userService = userService;
          _customerService = customerService;
        }
       
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            if (_cachedUser == null)
            {
                string asJson = await _jsRuntime.InvokeAsync<string>
                    ("sessionStorage.getItem", "currentUser");
                if (!string.IsNullOrEmpty(asJson))
                {
                    User tmp = JsonSerializer.Deserialize<User>(asJson);
                    await ValidateLoginAsync(tmp.Username, tmp.Password); 
                }
            }
            else
            {
                identity = SetupClaimsForUser(_cachedUser);
            }

            ClaimsPrincipal cachedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cachedClaimsPrincipal));
        }

        public async Task<string> ValidateRegisterAsync(Customer customer)
        {
            string hashPassword = HashString(customer.User.Password);
            customer.User.Password = hashPassword;
            return await _customerService.AddCustomerAsync(customer);
        }
        
        public async Task ValidateLoginAsync(string username,string password) 
        {
            if (string.IsNullOrEmpty(username)) throw new Exception("Enter username");
            if (string.IsNullOrEmpty(password)) throw new Exception("Enter password");

            ClaimsIdentity identity = new ClaimsIdentity();
            try
            {
                var hashedpassword = HashString(password);
                User userToValidate = await _userService.ValidateUserAsync(username, hashedpassword);
                storedUser = userToValidate;
                identity = SetupClaimsForUser(userToValidate);
                string serialisedData = JsonSerializer.Serialize(userToValidate);
                await _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serialisedData);
                _cachedUser = userToValidate;
            } 
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            NotifyAuthenticationStateChanged(
                Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
        }
        
        public void Logout() 
        {
            _cachedUser = null;
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
        
        private ClaimsIdentity SetupClaimsForUser(User user)
        {
            List<Claim> claims = new List<Claim>();
            //claims.Add(new Claim(ClaimTypes.Name, user.Username ));
            claims.Add(new Claim("Username",user.Username));
            ClaimsIdentity identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity;
            
       }
        
        private string HashString(string input)
        {
            using HashAlgorithm algorithm = SHA256.Create();
            var hashBytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            var hashedInputAsString = Encoding.ASCII.GetString(hashBytes);
            return hashedInputAsString;
        }
    }
}


