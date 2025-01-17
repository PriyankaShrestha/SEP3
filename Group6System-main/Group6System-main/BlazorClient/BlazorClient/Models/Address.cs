﻿using System;
using System.Text.Json.Serialization;

namespace BlazorClient.Models
{
    public class Address
    {
        [JsonPropertyName("city")]
        public City City { get; set; }
        
        [JsonPropertyName("streetname")]
        public String StreetName { get; set; }
        
        [JsonPropertyName("streetnumber")]
        public String StreetNumber { get; set; }
    }
}