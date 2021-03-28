using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Interfaces.Repositories.Games;
using Imi.Project.Api.Infrastructure.Data;
using Imi.Project.Api.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories.Games
{
    public class BoardGameRepository : EfRepository<BoardGame>, IBoardGameRepository
    {
        public BoardGameRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override IQueryable<BoardGame> GetAllAsync()
        {                                                                   // Get the impression there are too many includes for boardgames.. ¯\_(ツ)_/¯
            return _dbContext.BoardGames.AsNoTracking()                     // Get all boardgames with no tracking
                .Include(b => b.Artists).ThenInclude(ba => ba.Artist)       // Include BA table and then the artist
                .Include(b => b.Categories).ThenInclude(bc => bc.Category)  // Include BC table and then the category
                .Where(b => b.IsDeleted == false);
        }
        public override async Task<BoardGame> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(b => b.Id.Equals(id) && b.IsDeleted == false);
        }
        public async Task<IEnumerable<BoardGame>> GetByCategoryIdAsync(Guid id)
        {
            return await GetAllAsync().Where(b => b.Categories
                .Any(bc => bc.CategoryId.Equals(id)) && b.IsDeleted == false).ToListAsync();
        }
        public async Task<IEnumerable<BoardGame>> GetByArtistIdAsync(Guid id)
        {
            return await GetAllAsync().Where(b => b.Artists
            .Any(ba => ba.ArtistId.Equals(id))&& b.IsDeleted == false).ToListAsync();
        }
        public override async Task<BoardGame> DeleteAsync(BoardGame entity)
        {
            entity.IsDeleted = true;
            await UpdateAsync(entity);
            return entity;
        }
        public async Task<IEnumerable<BoardGame>> SearchByNameAsync(string name)
        {
            return await GetAllAsync().Where(b => b.Title.ToUpper().Contains(name.ToUpper())).ToListAsync();
        }
    }
}
