using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class BoardGameArtistRepository : EfCompositeRepository<BoardGameArtist>, IBoardGameArtistRepository
    {
        public BoardGameArtistRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override async Task<BoardGameArtist> AddAsync(IEnumerable<BoardGameArtist> entityList)
        {
            foreach (var item in entityList)
                await _dbContext.BoardGameArtists.AddAsync(item);
            //await _dbContext.SaveChangesAsync();
            return null;
        }
    }
}
