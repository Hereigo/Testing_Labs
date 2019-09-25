using System.ComponentModel.DataAnnotations;

namespace VSCode_WebAPI.Models
{
    public class Product
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(minimum: 0.01, maximum: (double)decimal.MaxValue)]
        public decimal Price { get; set; }
    }
}