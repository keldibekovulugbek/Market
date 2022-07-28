

using Market.Domain.Common;
using Market.Domain.Entities.Products;

namespace Market.Domain.Entities.Suppliers
{
    public class Supplier : Auditable
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string Address { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
