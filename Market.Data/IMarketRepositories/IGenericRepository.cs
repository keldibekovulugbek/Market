using Market.Domain.Common;
using System.Linq.Expressions;

namespace Market.Data.IMarketRepositories
{
    public interface IGenericRepository<T> where T : Auditable
    {
        IQueryable<T> Where(Expression<Func<T, bool>> predicate = null);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task<T> CreateAsync(T entity);
        T Update(T entity);
        Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate);
    }
}
