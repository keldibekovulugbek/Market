using Market.Data.DBContexts;
using Market.Data.IMarketRepositories;
using Market.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market.Data.MarketRepositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
    }
}
