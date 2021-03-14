using Imi.Project.Api.Core.Entities.Games;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class BoardGameCategorySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoardGameCategory>().HasData(
            #region Category Card
                new BoardGameCategory { BoardGameId = Guid.Parse("00000001-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0002-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000001-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0001-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000002-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0002-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000002-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0009-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000003-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0002-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000003-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0007-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000004-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0002-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000004-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0003-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000005-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0002-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000005-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0008-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000006-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0002-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000006-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0009-000000000000") },
            #endregion
            #region Category Party
                new BoardGameCategory { BoardGameId = Guid.Parse("00000007-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0003-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000007-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0002-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000008-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0003-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000008-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0002-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000009-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0003-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000010-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0003-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000011-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0003-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000012-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0003-000000000000") },
            #endregion
            #region Category Dice
                new BoardGameCategory { BoardGameId = Guid.Parse("00000013-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0004-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000013-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0007-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000014-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0004-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000014-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0007-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000015-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0004-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000016-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0004-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000016-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0003-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000017-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0004-000000000000") },
            #endregion
            #region Category Roll and Write
                new BoardGameCategory { BoardGameId = Guid.Parse("00000018-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0005-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000018-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0001-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000018-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0003-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000019-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0005-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000019-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0001-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000020-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0005-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000020-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0001-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000021-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0005-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000021-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0001-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000022-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0005-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000022-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0001-000000000000") },
            #endregion
            #region Category Fantasy
                new BoardGameCategory { BoardGameId = Guid.Parse("00000023-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0006-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000023-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0007-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000023-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0010-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000024-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0006-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000024-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0010-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000025-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0006-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000025-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0010-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000026-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0006-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000026-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0007-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000026-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0010-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000027-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0006-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000027-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0010-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000028-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0006-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000028-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0007-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000028-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0002-000000000000") },
            #endregion
            #region Category Animal
                new BoardGameCategory { BoardGameId = Guid.Parse("00000029-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0008-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000030-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0008-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000030-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0002-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000031-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0008-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000031-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0010-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000032-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0008-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000033-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0008-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000033-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0010-000000000000") },
            #endregion
            #region Category Miniature
                new BoardGameCategory { BoardGameId = Guid.Parse("00000034-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0010-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000034-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0002-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000035-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0010-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000035-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0002-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000035-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0006-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000036-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0010-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000036-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0009-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000037-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0010-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000037-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0006-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000038-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0010-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000038-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0006-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000039-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0010-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000039-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0006-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000039-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0007-000000000000") },
            #endregion
            #region Category Base Building
                new BoardGameCategory { BoardGameId = Guid.Parse("00000040-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0007-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000040-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0002-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000041-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0007-000000000000") },
                new BoardGameCategory { BoardGameId = Guid.Parse("00000041-0000-0000-0000-000000000000"), CategoryId = Guid.Parse("00000000-0000-0000-0001-000000000000") }
                #endregion
                );
        }
    }
}
