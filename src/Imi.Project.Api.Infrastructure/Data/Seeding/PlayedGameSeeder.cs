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
                    BoardGameId = Guid.Parse("00000006-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 480
                },
                new PlayedGame
                {
                    Id = Guid.Parse("40000000-0000-0000-0000-000000000000"),
                    BoardGameId = Guid.Parse("00000018-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 150
                },
                new PlayedGame
                {
                    Id = Guid.Parse("50000000-0000-0000-0000-000000000000"),
                    BoardGameId = Guid.Parse("00000033-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 60
                },
                new PlayedGame
                {
                    Id = Guid.Parse("50000000-0000-0000-0000-000000000000"),
                    BoardGameId = Guid.Parse("00000035-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 120
                },
                new PlayedGame
                {
                    Id = Guid.Parse("70000000-0000-0000-0000-000000000000"),
                    BoardGameId = Guid.Parse("00000038-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 360
                },
                new PlayedGame
                {
                    Id = Guid.Parse("80000000-0000-0000-0000-000000000000"),
                    BoardGameId = Guid.Parse("00000039-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 150
                },
                new PlayedGame
                {
                    Id = Guid.Parse("90000000-0000-0000-0000-000000000000"),
                    BoardGameId = Guid.Parse("00000026-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 360
                },
                new PlayedGame
                {
                    Id = Guid.Parse("11000000-0000-0000-0000-000000000000"),
                    BoardGameId = Guid.Parse("00000004-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 240
                },
                new PlayedGame
                {
                    Id = Guid.Parse("12000000-0000-0000-0000-000000000000"),
                    BoardGameId = Guid.Parse("00000007-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 200
                },
                new PlayedGame
                {
                    Id = Guid.Parse("13000000-0000-0000-0000-000000000000"),
                    BoardGameId = Guid.Parse("000000024-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 150
                },
                new PlayedGame
                {
                    Id = Guid.Parse("14000000-0000-0000-0000-000000000000"),
                    BoardGameId = Guid.Parse("00000023-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 500
                },
                new PlayedGame
                {
                    Id = Guid.Parse("15000000-0000-0000-0000-000000000000"),
                    BoardGameId = Guid.Parse("00000026-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 180
                },
                new PlayedGame
                {
                    Id = Guid.Parse("16000000-0000-0000-0000-000000000000"),
                    BoardGameId = Guid.Parse("00000017-0000-0000-0000-000000000000"),
                    IsDeleted = false,
                    PlayTime = 70
                }
                );
        }
    }
}
