﻿using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorClient.Models;

namespace BlazorClient.Data.UserService
{
    public class UserService: IUserService
    {
        private string path = "http://localhost:8080";
        public async Task<User> ValidateUserAsync(string username, string password)
        {
            HttpClient client = new HttpClient();
            Console.WriteLine(username + " " + password);
            User user = new User(username , password);
            /*  HttpResponseMessage response = await client.PostAsync($"{path}/users", );
              Console.WriteLine(response.StatusCode);
              if (response.IsSuccessStatusCode)
              {
                 
                  string asJson = await response.Content.ReadAsStringAsync();
                  User login = JsonSerializer.Deserialize<User>(asJson, new JsonSerializerOptions
                  {
                      PropertyNameCaseInsensitive = true
                  });
                  
                  return login;
              }
              Console.WriteLine(response.Content.ReadAsStringAsync().Result);
              throw new Exception(response.Content.ReadAsStringAsync().Result);*/
            
            string asJson = JsonSerializer.Serialize(user, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
            StringContent content = new StringContent(
                asJson,Encoding.UTF8, "application/json");
            
            HttpResponseMessage response = await client.PostAsync($"{path}/users", content);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
                return user;
            }

            else throw new Exception(response.Content.ReadAsStringAsync().Result);
        }
    }
}