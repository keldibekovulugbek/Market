using Market.Domain.Common;
using Market.Domain.Configurations;
using Market.Domain.Entities.Products;
using Market.Service.DTOs.ProductsDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market.Service.Interfaces
{
    public interface IProductService<Product>
    {
        Task<BaseResponse<Product>> CreateAsync(ProductForCreationDTO model, Expression<Func<Product, bool>> expression);
        Task<BaseResponse<Product>> UpdateAsync(Guid id, ProductForCreationDTO model);
        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Category, bool>> expression);
        Task<BaseResponse<Product>> GetAsync(Expression<Func<Product, bool>> expression);
        Task<BaseResponse<IEnumerable<Category>>> GetAllAsync(PaginationParams @params, Expression<Func<Category, bool>> expression = null);
        Task<BaseResponse<Product>> RestoreAsync(Expression<Func<Product, bool>> expression);
    }
}
