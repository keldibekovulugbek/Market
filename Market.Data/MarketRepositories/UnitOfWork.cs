using Market.Data.DBContexts;
using Market.Data.IMarketRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Data.MarketRepositories
{
    public class UnitOfWork : IUnitOfWork
    { 
        l
        public IProductRepository Products { get; }

        public ICategoryRepository Categories { get; }

        public ISupplierRepository Suppliers { get; }

        public MarketDBContext dbContext;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public  async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
