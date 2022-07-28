using Market.Domain.Common;
using Market.Domain.Configurations;
using Market.Domain.Entities.Suppliers;
using Market.Service.DTOs.SuppliersDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market.Service.Interfaces
{
    public interface ISupplierService<Supplier, SupplierForCreationDTO>
    {
        Task<BaseResponse<Supplier>> CreateAsync(SupplierForCreationDTO model, Expression<Func<Supplier, bool>> expression);
        Task<BaseResponse<Supplier>> UpdateAsync(Guid id, SupplierForCreationDTO model);
        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Supplier, bool>> expression);
        Task<BaseResponse<Supplier>> GetAsync(Expression<Func<Supplier, bool>> expression);
        Task<BaseResponse<IEnumerable<Supplier>>> GetAllAsync(PaginationParams @params, Expression<Func<Supplier, bool>> expression = null);
        
    }
}
