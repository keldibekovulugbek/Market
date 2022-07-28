using Market.Domain.Common;
using Market.Domain.Configurations;
using Market.Domain.Entities.Products;
using Market.Service.DTOs.ProductsDTOs;
using Market.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market.Service.Services
{
    public class ProductService : IProductService<Product, ProductForCreationDTO>
    {
        public Task<BaseResponse<Product>> CreateAsync(ProductForCreationDTO model, Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IEnumerable<Category>>> GetAllAsync(PaginationParams @params, Expression<Func<Category, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Product>> GetAsync(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Product>> UpdateAsync(Guid id, ProductForCreationDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
