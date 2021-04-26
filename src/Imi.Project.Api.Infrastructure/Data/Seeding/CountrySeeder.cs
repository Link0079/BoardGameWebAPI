using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class CountrySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), CountryCode = "BEL", IsDeleted = false, Name = "Belgium" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), CountryCode = "GER", IsDeleted = false, Name = "Germany" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), CountryCode = "ITA", IsDeleted = false, Name = "Italy" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), CountryCode = "USA", IsDeleted = false, Name = "United States" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), CountryCode = "GBR", IsDeleted = false, Name = "United Kingdom" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), CountryCode = "AUS", IsDeleted = false, Name = "Australia" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), CountryCode = "FRA", IsDeleted = false, Name = "France" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), CountryCode = "POL", IsDeleted = false, Name = "Poland" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), CountryCode = "RUS", IsDeleted = false, Name = "Russia" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), CountryCode = "NLD", IsDeleted = false, Name = "Netherlands" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), CountryCode = "AUT", IsDeleted = false, Name = "Austria" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), CountryCode = "ROM", IsDeleted = false, Name = "Romania" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), CountryCode = "CAN", IsDeleted = false, Name = "Canada" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), CountryCode = "CHN", IsDeleted = false, Name = "China" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000015"), CountryCode = "CZE", IsDeleted = false, Name = "Czech Republic" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000016"), CountryCode = "MAC", IsDeleted = false, Name = "Macedonia" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000017"), CountryCode = "THA", IsDeleted = false, Name = "Thailand" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000018"), CountryCode = "IND", IsDeleted = false, Name = "India" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000019"), CountryCode = "JPN", IsDeleted = false, Name = "Japan" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000020"), CountryCode = "SWE", IsDeleted = false, Name = "Sweden" }
                );
        }
    }
}
