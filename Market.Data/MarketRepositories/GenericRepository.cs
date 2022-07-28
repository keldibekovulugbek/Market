using Market.Data.DBContexts;
using Market.Data.IMarketRepositories;
using Market.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market.Data.MarketRepositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Auditable
    {
        internal MarketDBContext dbContext;
        internal DbSet<T> dbSet;
        public GenericRepository(MarketDBContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = dbContext.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
                => (await dbSet.AddAsync(entity)).Entity;

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate)
            => dbSet.FirstOrDefaultAsync(predicate);

        public T Update(T entity)
            => dbSet.Update(entity).Entity;

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate = null)
            => predicate is null ? dbSet : dbSet.Where(predicate);
        
        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var entity = dbSet.FirstOrDefault(predicate);
            if (entity is not null)
            {
                dbSet.Remove(entity);
                return true;
            }
            return false;
        }

        public Task SaveAsync()
           => this.dbContext.SaveChangesAsync();
        
    }
}
