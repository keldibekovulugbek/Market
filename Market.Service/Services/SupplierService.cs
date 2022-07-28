using Market.Domain.Common;
using Market.Domain.Configurations;
using Market.Domain.Entities.Suppliers;
using Market.Service.DTOs.SuppliersDTOs;
using Market.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market.Service.Services
{
    public class SupplierService : ISupplierService<Supplier, SupplierForCreationDTO>
    {
        public Task<BaseResponse<Supplier>> CreateAsync(SupplierForCreationDTO model, Expression<Func<Supplier, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Supplier, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IEnumerable<Supplier>>> GetAllAsync(PaginationParams @params, Expression<Func<Supplier, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Supplier>> GetAsync(Expression<Func<Supplier, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Supplier>> UpdateAsync(Guid id, SupplierForCreationDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
