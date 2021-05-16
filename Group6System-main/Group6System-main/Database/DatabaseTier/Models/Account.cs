﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DatabaseTier.Models
{
    public class Account
    {
        [Key]
        public long AccountNumber { get; set; }
        [JsonPropertyName("balance")]
        public double  Balance{ get; set; }
        [JsonPropertyName("date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date{ get; set; }

        public override string ToString()
        {
            return "Account{" +
                   "accountnumber=" + AccountNumber +
                   "balance=" + Balance +
                   '}';
            
        }
        
    }
}