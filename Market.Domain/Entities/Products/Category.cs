using Market.Domain.Common;


namespace Market.Domain.Entities.Products
{
    public class Category : Auditable
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<Product> Products { get; set; }

    }
}
