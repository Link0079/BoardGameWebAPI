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
                new GameScore { PlayedGameId = Guid.Parse("30000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-500000000000"), IsDeleted = false, Score = 2 },
            #endregion
            #region Welcome Too..
                new GameScore { PlayedGameId = Guid.Parse("40000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-200000000000"), IsDeleted = false, Score = 60 },
                new GameScore { PlayedGameId = Guid.Parse("40000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-210000000000"), IsDeleted = false, Score = 65 },
                new GameScore { PlayedGameId = Guid.Parse("40000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-220000000000"), IsDeleted = false, Score = 69 },
                new GameScore { PlayedGameId = Guid.Parse("40000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-230000000000"), IsDeleted = false, Score = 67 },
                new GameScore { PlayedGameId = Guid.Parse("40000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-240000000000"), IsDeleted = false, Score = 76 },
                new GameScore { PlayedGameId = Guid.Parse("40000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-250000000000"), IsDeleted = false, Score = 96 },
                new GameScore { PlayedGameId = Guid.Parse("40000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-260000000000"), IsDeleted = false, Score = 36 },
                new GameScore { PlayedGameId = Guid.Parse("40000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-110000000000"), IsDeleted = false, Score = 56 },
                new GameScore { PlayedGameId = Guid.Parse("40000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-120000000000"), IsDeleted = false, Score = 66 },
                new GameScore { PlayedGameId = Guid.Parse("40000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-130000000000"), IsDeleted = false, Score = 61 },
            #endregion
            #region Dinosaur Island
                new GameScore { PlayedGameId = Guid.Parse("50000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-140000000000"), IsDeleted = false, Score = 30 },
                new GameScore { PlayedGameId = Guid.Parse("50000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-150000000000"), IsDeleted = false, Score = 40 },
                new GameScore { PlayedGameId = Guid.Parse("50000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-160000000000"), IsDeleted = false, Score = 50 },
                new GameScore { PlayedGameId = Guid.Parse("50000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-170000000000"), IsDeleted = false, Score = 60 },
            #endregion
            #region Blood Rage
                new GameScore { PlayedGameId = Guid.Parse("60000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-100000000000"), IsDeleted = false, Score = 1 },
                new GameScore { PlayedGameId = Guid.Parse("60000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-400000000000"), IsDeleted = false, Score = 2 },
                new GameScore { PlayedGameId = Guid.Parse("60000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-220000000000"), IsDeleted = false, Score = 3 },
                new GameScore { PlayedGameId = Guid.Parse("60000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-140000000000"), IsDeleted = false, Score = 4 },
            #endregion
            #region A Game Of Thrones
                new GameScore { PlayedGameId = Guid.Parse("70000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-200000000000"), IsDeleted = false, Score = 1 },
                new GameScore { PlayedGameId = Guid.Parse("70000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-800000000000"), IsDeleted = false, Score = 2 },
                new GameScore { PlayedGameId = Guid.Parse("70000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-900000000000"), IsDeleted = false, Score = 3 },
                new GameScore { PlayedGameId = Guid.Parse("70000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-700000000000"), IsDeleted = false, Score = 4 },
                new GameScore { PlayedGameId = Guid.Parse("70000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-600000000000"), IsDeleted = false, Score = 5 },
                new GameScore { PlayedGameId = Guid.Parse("70000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-500000000000"), IsDeleted = false, Score = 6 },
            #endregion
            #region Rising Sun
                new GameScore { PlayedGameId = Guid.Parse("80000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-100000000000"), IsDeleted = false, Score = 50 },
                new GameScore { PlayedGameId = Guid.Parse("80000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-200000000000"), IsDeleted = false, Score = 60 },
                new GameScore { PlayedGameId = Guid.Parse("80000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-300000000000"), IsDeleted = false, Score = 25 },
                new GameScore { PlayedGameId = Guid.Parse("80000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-400000000000"), IsDeleted = false, Score = 15 },
                new GameScore { PlayedGameId = Guid.Parse("80000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-500000000000"), IsDeleted = false, Score = 30 },
            #endregion
            #region Heroes of Land, Air and Sea
                new GameScore { PlayedGameId = Guid.Parse("90000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-100000000000"), IsDeleted = false, Score = 1 },
                new GameScore { PlayedGameId = Guid.Parse("90000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-200000000000"), IsDeleted = false, Score = 2 },
                new GameScore { PlayedGameId = Guid.Parse("90000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-150000000000"), IsDeleted = false, Score = 4 },
                new GameScore { PlayedGameId = Guid.Parse("90000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-250000000000"), IsDeleted = false, Score = 3 },
            #endregion
            #region Joking Hazard
                new GameScore { PlayedGameId = Guid.Parse("11000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-500000000000"), IsDeleted = false, Score = 1 },
                new GameScore { PlayedGameId = Guid.Parse("11000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-110000000000"), IsDeleted = false, Score = 2 },
                new GameScore { PlayedGameId = Guid.Parse("11000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-160000000000"), IsDeleted = false, Score = 6 },
                new GameScore { PlayedGameId = Guid.Parse("11000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-210000000000"), IsDeleted = false, Score = 8 },
                new GameScore { PlayedGameId = Guid.Parse("11000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-260000000000"), IsDeleted = false, Score = 7 },
                new GameScore { PlayedGameId = Guid.Parse("11000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-230000000000"), IsDeleted = false, Score = 3 },
                new GameScore { PlayedGameId = Guid.Parse("11000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-130000000000"), IsDeleted = false, Score = 5 },
                new GameScore { PlayedGameId = Guid.Parse("11000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-700000000000"), IsDeleted = false, Score = 4 },
            #endregion
            #region Secret Hitler
                new GameScore { PlayedGameId = Guid.Parse("12000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-100000000000"), IsDeleted = false, Score = 1 },
                new GameScore { PlayedGameId = Guid.Parse("12000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-200000000000"), IsDeleted = false, Score = 1 },
                new GameScore { PlayedGameId = Guid.Parse("12000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-300000000000"), IsDeleted = false, Score = 2 },
                new GameScore { PlayedGameId = Guid.Parse("12000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-400000000000"), IsDeleted = false, Score = 2 },
                new GameScore { PlayedGameId = Guid.Parse("12000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-500000000000"), IsDeleted = false, Score = 2 },
                new GameScore { PlayedGameId = Guid.Parse("12000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-600000000000"), IsDeleted = false, Score = 2 },
                new GameScore { PlayedGameId = Guid.Parse("12000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-700000000000"), IsDeleted = false, Score = 1 },
                new GameScore { PlayedGameId = Guid.Parse("12000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-800000000000"), IsDeleted = false, Score = 2 },
                new GameScore { PlayedGameId = Guid.Parse("12000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-900000000000"), IsDeleted = false, Score = 2 },
                new GameScore { PlayedGameId = Guid.Parse("12000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-190000000000"), IsDeleted = false, Score = 1 },
            #endregion
            #region Merchants and Marauders
                new GameScore { PlayedGameId = Guid.Parse("13000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-230000000000"), IsDeleted = false, Score = 66 },
                new GameScore { PlayedGameId = Guid.Parse("13000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-260000000000"), IsDeleted = false, Score = 65 },
                new GameScore { PlayedGameId = Guid.Parse("13000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-250000000000"), IsDeleted = false, Score = 67 },
                new GameScore { PlayedGameId = Guid.Parse("13000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-240000000000"), IsDeleted = false, Score = 96 },
            #endregion
            #region Twilight Imperium
                new GameScore { PlayedGameId = Guid.Parse("14000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-100000000000"), IsDeleted = false, Score = 10 },
                new GameScore { PlayedGameId = Guid.Parse("14000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-190000000000"), IsDeleted = false, Score = 9 },
                new GameScore { PlayedGameId = Guid.Parse("14000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-900000000000"), IsDeleted = false, Score = 8 },
                new GameScore { PlayedGameId = Guid.Parse("14000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-110000000000"), IsDeleted = false, Score = 9 },
                new GameScore { PlayedGameId = Guid.Parse("14000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-210000000000"), IsDeleted = false, Score = 5 },
                new GameScore { PlayedGameId = Guid.Parse("14000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-120000000000"), IsDeleted = false, Score = 7 },
                new GameScore { PlayedGameId = Guid.Parse("14000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-220000000000"), IsDeleted = false, Score = 5 },
            #endregion
            #region Heroes of Land, Air and Sea
                new GameScore { PlayedGameId = Guid.Parse("15000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-100000000000"), IsDeleted = false, Score = 6 },
                new GameScore { PlayedGameId = Guid.Parse("15000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-190000000000"), IsDeleted = false, Score = 6 },
                new GameScore { PlayedGameId = Guid.Parse("15000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-200000000000"), IsDeleted = false, Score = 6 },
                new GameScore { PlayedGameId = Guid.Parse("15000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-150000000000"), IsDeleted = false, Score = 6 },
            #endregion
            #region Too Many Bones
                new GameScore { PlayedGameId = Guid.Parse("16000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-180000000000"), IsDeleted = false, Score = 65 },
                new GameScore { PlayedGameId = Guid.Parse("16000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-210000000000"), IsDeleted = false, Score = 90 },
                new GameScore { PlayedGameId = Guid.Parse("16000000-0000-0000-0000-000000000000"), PlayerId = Guid.Parse("00000000-0000-0000-0000-120000000000"), IsDeleted = false, Score = 30 }
            #endregion
                );
        }

    }
}
