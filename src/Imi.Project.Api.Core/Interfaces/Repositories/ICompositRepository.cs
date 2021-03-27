using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface ICompositRepository<T> where T : class
    {
        IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate);
        Task<T> AddAsync(IEnumerable<T> entityList);
        Task<T> DeleteAsync(IEnumerable<T> entityList);
    }
}
