

namespace Market.Data.IMarketRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        ISupplierRepository Suppliers { get; }
        Task SaveChangesAsync();
    
    }
}
