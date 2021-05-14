using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories.Base
{
    public interface IUserRepository<TUser> where TUser : IdentityUser<Guid>
    {
        Task<TUser> GetByIdAsync(Guid id);
        Task<TUser> GetByIdAsync(Guid id, string[] includes);
        IQueryable<TUser> GetAllAsync();
        Task<IEnumerable<TUser>> ListAllAsync();
        IQueryable<TUser> GetFiltered(Expression<Func<TUser, bool>> predicate);
        Task<IEnumerable<TUser>> ListFiltered(Expression<Func<TUser, bool>> predicate);
        Task<TUser> AddAsync(TUser entity);
        Task<TUser> UpdateAsync(TUser entity);
        Task<TUser> DeleteAsync(TUser entity);
        Task<TUser> DeleteAsync(Guid id);
        Task<bool> EntityExists(Guid id);
    }
}
