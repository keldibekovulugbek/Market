

using Market.Domain.Common;
using Market.Domain.Entities.Products;

namespace Market.Domain.Entities.Suppliers
{
    public class Supplier : Auditable
    {
        
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;
        public ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
