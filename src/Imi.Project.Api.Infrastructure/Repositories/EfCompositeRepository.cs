using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class EfCompositeRepository<T> : ICompositRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _dbContext;
        public EfCompositeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T> AddAsync(IEnumerable<T> entityList)
        {
            foreach (var item in entityList)
                await _dbContext.Set<T>().AddAsync(item);
            //await _dbContext.SaveChangesAsync();
            return null;
        }
        public virtual async Task<T> DeleteAsync(IEnumerable<T> entityList)
        {
            _dbContext.Set<T>().RemoveRange(entityList);
            await _dbContext.SaveChangesAsync();
            return null;
        }
        // no implementation yet.. now no use for it
        public IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
