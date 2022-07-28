using Market.Domain.Common;
using Market.Domain.Entities.Suppliers;

namespace Market.Domain.Entities.Products
{
    public class Product : Auditable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public int Discount { get; set; } = 0;
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }

    }
}
