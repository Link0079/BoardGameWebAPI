using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class PublisherSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publisher>().HasData(
            #region Publishers
                new Publisher { Id = Guid.Parse("00000000-0000-0001-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Days of Wonder" },
                new Publisher { Id = Guid.Parse("00000000-0000-0002-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000013"), Name = "Roxley" },
                new Publisher { Id = Guid.Parse("00000000-0000-0004-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "NSKN" },
                new Publisher { Id = Guid.Parse("00000000-0000-0005-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Gamelyn Games" },
                new Publisher { Id = Guid.Parse("00000000-0000-0006-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Fantasy Flight Games" },
                new Publisher { Id = Guid.Parse("00000000-0000-0007-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Matagot" },
                new Publisher { Id = Guid.Parse("00000000-0000-0008-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Goat Wolf and Gabbage" },
                new Publisher { Id = Guid.Parse("00000000-0000-0009-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Portal Games" },
                new Publisher { Id = Guid.Parse("00000000-0000-0010-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Blue Cocker Games" },
                new Publisher { Id = Guid.Parse("00000000-0000-0011-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000014"), Name = "CMON Limited" },
                new Publisher { Id = Guid.Parse("00000000-0000-0012-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Feuerland Spiele" },
                new Publisher { Id = Guid.Parse("00000000-0000-0013-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Lookout Games" },
                new Publisher { Id = Guid.Parse("00000000-0000-0014-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Awaken Realms" },
                new Publisher { Id = Guid.Parse("00000000-0000-0015-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Pegasus Spiele" },
                new Publisher { Id = Guid.Parse("00000000-0000-0016-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Ares Games" },
                new Publisher { Id = Guid.Parse("00000000-0000-0017-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Chip Theory Games" },
                new Publisher { Id = Guid.Parse("00000000-0000-0018-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Alley Cat Games" },
                new Publisher { Id = Guid.Parse("00000000-0000-0019-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Breaking Games" },
                new Publisher { Id = Guid.Parse("00000000-0000-0020-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Stonemaier Games" },
                new Publisher { Id = Guid.Parse("00000000-0000-0021-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Dire Wolf" },
                new Publisher { Id = Guid.Parse("00000000-0000-0022-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Cephalofair Games" },
                new Publisher { Id = Guid.Parse("00000000-0000-0023-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Stronghold Games" },
                new Publisher { Id = Guid.Parse("00000000-0000-0024-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Serious Poulp" }
                #endregion                
                );
        }
    }
}
