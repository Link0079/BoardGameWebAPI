using Imi.Project.Api.Core.Entities.Games;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class PlayedGameSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayedGame>().HasData(
                new PlayedGame
                {
                    Id = Guid.Parse("10000000-0000-0000-0000-000000000000"),
                    BoardGameId = Guid.Parse("00000040-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 160
                },
                new PlayedGame
                {
                    Id = Guid.Parse("20000000-0000-0000-0000-000000000000"),
                    BoardGameId = Guid.Parse("00000005-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 70
                },
                new PlayedGame
                {
                    Id = Guid.Parse("30000000-0000-0000-0000-000000000000"),
                    BoardGameId = Guid.Parse("00000023-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 480
                });
        }
    }
}
