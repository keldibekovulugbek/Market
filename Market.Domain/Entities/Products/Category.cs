using Market.Domain.Common;


namespace Market.Domain.Entities.Products
{
    public class Category : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
