using AutoMapper;
using Market.Data.IMarketRepositories;
using Market.Data.MarketRepositories;
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
    public class CategoryService : ICategoryService<Category, CategoryForCreationDTO>
    {
        public CategoryService()
        {
            IUnitOfWork unitOfWork,
                IMapper mapper,
                GenericRepository<Category> genericRepository
                


        }
        public Task<BaseResponse<Category>> CreateAsync(CategoryForCreationDTO model, Expression<Func<Category, bool>> expression)
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

        public Task<BaseResponse<Category>> GetAsync(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Category>> UpdateAsync(Guid id, CategoryForCreationDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
