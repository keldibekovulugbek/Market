using Market.Data.DBContexts;
using Market.Data.IMarketRepositories;
using Market.Domain.Entities.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Data.MarketRepositories
{
    public class SupplierRepository : GenericRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(MarketDBContext context) : base(context)
        {

        }
    }
}
