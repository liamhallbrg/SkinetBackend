using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class ProductToReturnDto
    {
        [Required]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string PictureUrl { get; set; }

        public string ProductType { get; set; }
        public string ProductBrand { get; set; }
    }
}
