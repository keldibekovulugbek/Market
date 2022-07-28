using Market.Domain.Common;
using Market.Domain.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market.Service.Interfaces
{
    public interface ICategoryService<Category,CategoryForCreationDTO>
    {
        Task<BaseResponse<Category>> CreateAsync(CategoryForCreationDTO model, Expression<Func<Category, bool>> expression);
        Task<BaseResponse<Category>> UpdateAsync(Guid id, CategoryForCreationDTO model);
        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Category, bool>> expression);
        Task<BaseResponse<Category>> GetAsync(Expression<Func<Category, bool>> expression);
        Task<BaseResponse<IEnumerable<Category>>> GetAllAsync(PaginationParams @params, Expression<Func<Category, bool>> expression = null);
        Task<BaseResponse<Category>> RestoreAsync(Expression<Func<Category, bool>> expression);
    }
}
