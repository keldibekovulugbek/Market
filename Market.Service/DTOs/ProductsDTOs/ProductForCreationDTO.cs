using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Service.DTOs.ProductsDTOs
{
    public class ProductForCreationDTO
    {
        [Required,MinLength(4),MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required, MinLength(4), MaxLength(600)]
        public string Description { get; set; }
        public int Discount { get; set; } = 0;
    }
}
