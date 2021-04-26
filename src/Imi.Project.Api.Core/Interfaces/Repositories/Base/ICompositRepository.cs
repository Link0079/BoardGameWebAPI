using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories.Base
{
    public interface ICompositRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetByIdAsync(Guid id);
        Task<T> GetByIdAsync(Guid id, string[] includes);
        IQueryable<T> GetAllAsync();
        Task<IEnumerable<T>> ListAllAsync();
        IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> AddAsync(IEnumerable<T> entityList);
        Task<IEnumerable<T>> UpdateAsync(IEnumerable<T> entityList);
        Task<IEnumerable<T>> DeleteAsync(IEnumerable<T> entityList);
        Task<T> DeleteAsync(Guid id);
    }
}
