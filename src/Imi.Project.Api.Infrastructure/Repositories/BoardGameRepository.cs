using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class BoardGameRepository : EfRepository<BoardGame>
    {
        public BoardGameRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override IQueryable<BoardGame> GetAllAsync()
        {                                                                   // Get the impression there are too many includes for boardgames.. ¯\_(ツ)_/¯
            return _dbContext.BoardGames.AsNoTracking()                     // Get all boardgames with no tracking
                .Include(b => b.Artists).ThenInclude(ba => ba.Artist)       // Include BA table and then the artist
                .Include(b => b.Categories).ThenInclude(bc => bc.Category)  // Include BC table and then the category
                .Include(b => b.Country)                                    // Include the country table
                .Include(b => b.Publisher);                                 // Include the publisher table
        }
        public override async Task<BoardGame> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(b => b.Id.Equals(id));
        }
    }
}
