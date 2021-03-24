using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
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
                .Include(b => b.Categories).ThenInclude(bc => bc.Category);  // Include BC table and then the category
        }
        public override async Task<BoardGame> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(b => b.Id.Equals(id));
        }

        public async Task<IEnumerable<BoardGame>> GetByCategoryIdAsync(Guid id)
        {
            return await GetAllAsync().Where(b => b.Categories
                .Any(bc => bc.CategoryId.Equals(id))).ToListAsync();
        }
        public async Task<IEnumerable<BoardGame>> GetByArtistIdAsync(Guid id)
        {
            return await GetAllAsync().Where(b => b.Artists
            .Any(ba => ba.ArtistId.Equals(id))).ToListAsync();
        }
        public override async Task<BoardGame> UpdateAsync(BoardGame entity)
        {
            var deleteCategoryList = _dbContext.Set<BoardGameCategory>().Where(b=>b.BoardGameId == entity.Id).ToList();
            var deleteArtistList = _dbContext.Set<BoardGameArtist>().Where(b => b.BoardGameId == entity.Id).ToList();
            _dbContext.Set<BoardGameCategory>().RemoveRange(deleteCategoryList);
            _dbContext.Set<BoardGameArtist>().RemoveRange(deleteArtistList);
            await _dbContext.SaveChangesAsync();
            await base.DeleteAsync(entity.Id);
            return await base.AddAsync(entity);
        }
    }
}
