

namespace Market.Data.IMarketRepositories
{
    internal interface IUnitOfWork : IDisposable
    {
        IProductRepository Users { get; }
        ICategoryRepository Courses { get; }
        ISupplierRepository Authors { get; }
        Task SaveChangesAsync();
    
    }
}
