using Imi.Project.Api.Core.Interfaces.Repositories.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories.Base
{
    public class EfUserRepository<TUser> : IUserRepository<TUser> where TUser : IdentityUser<Guid>
    {
        protected readonly UserManager<TUser> _userManager;
        public EfUserRepository(UserManager<TUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<TUser> AddAsync(TUser entity)
        {
            await _userManager.CreateAsync(entity);
            return entity;
        }
        public virtual async Task<TUser> DeleteAsync(TUser entity)
        {
            await _userManager.DeleteAsync(entity);
            return entity;
        }
        public async Task<TUser> DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            await DeleteAsync(entity);
            return entity;
        }
        public virtual IQueryable<TUser> GetAllAsync()
        {
            return _userManager.Users.AsNoTracking();
        }
        public virtual async Task<TUser> GetByIdAsync(Guid id)
        {
            return await _userManager.FindByIdAsync(id.ToString());
        }
        public async Task<TUser> GetByIdAsync(Guid id, string[] includes)
        {
            var query = GetAllAsync();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query.SingleOrDefaultAsync(t => t.Id.Equals(id));
        }
        public IQueryable<TUser> GetFiltered(Expression<Func<TUser, bool>> predicate)
        {
            return _userManager.Users.Where(predicate).AsQueryable();
        }
        public async Task<IEnumerable<TUser>> ListAllAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
        public async Task<IEnumerable<TUser>> ListFiltered(Expression<Func<TUser, bool>> predicate)
        {
            return await GetFiltered(predicate).ToListAsync();
        }
        public virtual async Task<TUser> UpdateAsync(TUser entity)
        {
            await _userManager.UpdateAsync(entity);
            return entity;
        }
    }
}
