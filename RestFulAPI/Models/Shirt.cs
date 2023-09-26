﻿using RestFulAPI.Validation;

namespace RestFulAPI.Models
{
    public class Shirt
    {
        public int ShirId { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        [ShirtModelValidation]
        public int Size { get; set; }
        public string? Gender { get; set; }
        public decimal Price { get; set; }
    }
}
