﻿using System.ComponentModel.DataAnnotations;

namespace MangoRestaurant.Services.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Range(1, 1000)]
        public double Price { get; set; }
        
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }
    }
}
