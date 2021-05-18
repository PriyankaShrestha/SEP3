﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorClient.Models;

namespace BlazorClient.Data.CustomerService
{
    public class CustomerService:ICustomerService
    {
        private readonly HttpClient _client = new HttpClient();
        private string path = "http://localhost:8080";
        
        public async Task<String> AddCustomerAsync(Customer user)
        {
            string AsJson = JsonSerializer.Serialize(user, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
            StringContent content = new StringContent(
                AsJson,Encoding.UTF8, "application/json");
            
            HttpResponseMessage response = await _client.PostAsync($"{path}/createNewCustomer", content);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }

            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }
        
        public async Task RemoveCustomerAsync(int cprNumber)
        {
            HttpResponseMessage response = await _client.DeleteAsync($"{path}/removeCustomer/{cprNumber}");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                throw new Exception($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<IList<Customer>> GetAllCustomersAsync()
        {
            HttpResponseMessage response = await _client.GetAsync($"{path}/getCustomers");
            Console.WriteLine(response.Content);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);
                IList<Customer> customers = JsonSerializer.Deserialize<IList<Customer>>(result, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return customers;
            }

            throw new Exception($"Error: {response.StatusCode}, {response.ReasonPhrase}");
        }

        public async Task UpdateCustomerAsync(Customer customer)
        {
            string asJson = JsonSerializer.Serialize(customer);
            StringContent content = new StringContent(asJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PatchAsync($"{path}/updateCustomer", content);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                Console.WriteLine($@"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }
    }
}