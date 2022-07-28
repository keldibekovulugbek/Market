using AutoMapper;
using Market.Data.DBContexts;
using Market.Data.IMarketRepositories;
using Market.Data.MarketRepositories;
using Market.Domain.Common;
using Market.Domain.Configurations;
using Market.Domain.Entities.Products;
using Market.Domain.Enums;
using Market.Service.DTOs.ProductsDTOs;
using Market.Service.Interfaces;
using Market.Service.Mappers;
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
        protected readonly ICategoryRepository genericRepository;
        private readonly IMapper mapper;
        private readonly MarketDBContext dBContext;

        public CategoryService()
        {
            genericRepository = new CategoryRepository();
            mapper = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile())).CreateMapper();
        }
        public async Task<BaseResponse<Category>> CreateAsync(CategoryForCreationDTO model, Expression<Func<Category, bool>> expression)
        {
            var response = new BaseResponse<Category>();

            var exist = await genericRepository.GetAsync(expression);
            if (exist != null )
            {
                response.Error = new ErrorResponse(400, "This catagory name already exist");
                return response;
            }
            var entity = mapper.Map<Category>(model);
            entity.OnCreated();
            response.Data = await genericRepository.CreateAsync(entity);
            await genericRepository.SaveAsync();
            return response;
        }

        public async Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Category, bool>> expression)
        {
            var response = new BaseResponse<bool>();
            var exist = await genericRepository.GetAsync(expression);

            if (exist == null)
            {
                response.Error = new ErrorResponse(404, "This catagory does not exist");
                return response;
            }
            exist.OnDeleted();

            await genericRepository.SaveAsync();

            response.Data = true;   
            return response;

        }

        public Task<BaseResponse<IEnumerable<Category>>> GetAllAsync(PaginationParams @params, Expression<Func<Category, bool>> expression = null)
        {
            //var response = new BaseResponse<IEnumerable<Category>>();
            //var catagories = genericRepository.Where(expression).Where(p=> p.ItemState!=ItemState.Deleted);
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
