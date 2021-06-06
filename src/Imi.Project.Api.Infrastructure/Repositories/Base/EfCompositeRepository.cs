using Imi.Project.Api.Core.Interfaces.Repositories.Base;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories.Base
{
    public class EfCompositeRepository<T> : ICompositRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _dbContext;
        public EfCompositeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddAsync(IEnumerable<T> entityList)
        {
            foreach (var item in entityList)
                await _dbContext.Set<T>().AddAsync(item);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteAsync(IEnumerable<T> entityList)
        {
             _dbContext.Set<T>().RemoveRange(entityList);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public virtual Task<IEnumerable<T>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        public Task<T> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        public IQueryable<T> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public Task<T> GetByIdAsync(Guid id, string[] includes)
        {
            throw new NotImplementedException();
        }
        public IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate).AsQueryable();
        }
        public Task<IEnumerable<T>> ListAllAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate)
        {
            return await GetFiltered(predicate).ToListAsync();
        }
        public Task<bool> UpdateAsync(IEnumerable<T> entityList)
        {
            throw new NotImplementedException();
        }
    }
}
