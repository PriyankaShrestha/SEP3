﻿using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseTier.Models;

namespace DatabaseTier.Repository.AdminREPO
{
    public interface IAdminRepository
    {
        Task<Customer> ValidateCustomerAsync(Customer customer);
        Task<IEnumerable<Customer>> GetAllCustomersAsync();
        Task RemoveCustomerAsync(int cprNumber);
    }
}