﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DatabaseTier.Models
{
    public class Account
    {
        [Key, JsonPropertyName("accountNumber")]
        public long AccountNumber { get; set; }
        
        [JsonPropertyName("balance")]
        public double  Balance{ get; set; }
        
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }
        
        // [JsonPropertyName("transactions")]
        // public IList<Transaction> Transactions { get; set; }
        
        [JsonPropertyName("date")]
        public String Date{ get; set; }

        public override string ToString()
        {
            return "Account{" +
                "accountNumber=" + AccountNumber +
                "balance=" + Balance +
                "customer=" + Customer.CprNumber +
                "date=" + Date +
                '}'; 
        }
    }
}