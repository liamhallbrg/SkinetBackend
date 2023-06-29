﻿using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string PictureUrl { get; set; }

        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }

        public ProductBrand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }
    }
}
