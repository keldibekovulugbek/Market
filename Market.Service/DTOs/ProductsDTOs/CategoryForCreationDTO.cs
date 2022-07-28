using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Service.DTOs.ProductsDTOs
{
    public class CategoryForCreationDTO
    {
        [Required, MinLength(3), MaxLength(30)]
        public string Name { get; set; }
        [Required, MinLength(5),MaxLength(600)]
        public string Description { get; set; }
    }
}
