using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Service.DTOs.SuppliersDTOs
{
    public class SupplierForCreationDTO
    {
        [Required, MinLength(3), MaxLength(30)]
        public string Name { get; set; }
        [Required, MinLength(12), MaxLength(20),Phone]
        public string PhoneNumber { get; set; }
        [Required, MinLength(3), MaxLength(30),EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(3), MaxLength(50)]
        public string Address { get; set; }
    }
}
