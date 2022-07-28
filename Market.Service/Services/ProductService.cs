using AutoMapper;
using Market.Data.DBContexts;
using Market.Domain.Common;
using Market.Domain.Configurations;
using Market.Domain.Entities.Products;
using Market.Service.DTOs.ProductsDTOs;
using Market.Service.Interfaces;
using Market.Service.Services;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

// Create to Category DBSet
namespace Market.Service.Services
{
    public class ProductService : IProductService<Product, ProductForCreationDTO>
    {
        private readonly MarketDBContext _dbContext;
        private readonly IMapper _mapper;
        public ProductService(MarketDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<BaseResponse<Product>> CreateAsync(ProductForCreationDTO model)
        {
            var product = _mapper.Map<Product>(model);
            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
            return new BaseResponse<Product>
            {
                Data = product,
                Error = new ErrorResponse(200, "Product created successfully") { Code = 200 }

            };
        }


        public async Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Product, bool>> expression)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(expression);
            if (product == null)
            {
                return new BaseResponse<bool>
                {
                    Error = new ErrorResponse(404, "Product not found") { Code = 404 }

                };
            }
            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();
            return new BaseResponse<bool>
            {
                Error = new ErrorResponse(200, "Product deleted successfully") { Code = 200 }
            };
        }

        public Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<IEnumerable<Product>>> GetAllAsync(PaginationParams @params, Expression<Func<Product, bool>> expression = null)
        {
            var products = await _dbContext.Products.Where(expression).Skip((@params.PageSize - 1) * @params.PageSize).Take(@params.PageSize).ToListAsync();
            return new BaseResponse<IEnumerable<Product>>
            {
                Data = products,
                Error = new ErrorResponse(200, "Products retrieved successfully") { Code = 200 }
            };
        }

       
    }
}

