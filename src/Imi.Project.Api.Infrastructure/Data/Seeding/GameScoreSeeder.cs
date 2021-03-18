using Imi.Project.Api.Core.Entities.Games;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class GameScoreSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameScore>().HasData(
            #region Brass: Birmingham
                new GameScore { PlayedGameId = Guid.Parse("10000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-100000000000"), IsDeleted = false, Score = 20 },
                new GameScore { PlayedGameId = Guid.Parse("10000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-200000000000"), IsDeleted = false, Score = 30 },
                new GameScore { PlayedGameId = Guid.Parse("10000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-400000000000"), IsDeleted = false, Score = 40 },
            #endregion
            #region Wingspan
                new GameScore { PlayedGameId = Guid.Parse("20000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-100000000000"), IsDeleted = false, Score = 30 },
                new GameScore { PlayedGameId = Guid.Parse("20000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-200000000000"), IsDeleted = false, Score = 25 },
                new GameScore { PlayedGameId = Guid.Parse("20000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-400000000000"), IsDeleted = false, Score = 40 },
                new GameScore { PlayedGameId = Guid.Parse("20000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-500000000000"), IsDeleted = false, Score = 20 },
            #endregion
            #region Twilight Imperium
                new GameScore { PlayedGameId = Guid.Parse("30000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-100000000000"), IsDeleted = false, Score = 6 },
                new GameScore { PlayedGameId = Guid.Parse("30000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-200000000000"), IsDeleted = false, Score = 8 },
                new GameScore { PlayedGameId = Guid.Parse("30000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-300000000000"), IsDeleted = false, Score = 10 },
                new GameScore { PlayedGameId = Guid.Parse("30000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-400000000000"), IsDeleted = false, Score = 4 },
                new GameScore { PlayedGameId = Guid.Parse("30000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-500000000000"), IsDeleted = false, Score = 2 }
                #endregion
                );
        }

    }
}
