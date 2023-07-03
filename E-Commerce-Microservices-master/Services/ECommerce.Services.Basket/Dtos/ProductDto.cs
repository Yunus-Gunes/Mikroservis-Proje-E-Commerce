﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Services.Basket.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
    }
}
