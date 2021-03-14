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
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), CountryCode = "BEL", Name = "Belgium" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), CountryCode = "GER", Name = "Germany" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), CountryCode = "ITA", Name = "Italy" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), CountryCode = "USA", Name = "United States" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), CountryCode = "GBR", Name = "United Kingdom" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), CountryCode = "AUS", Name = "Australia" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), CountryCode = "FRA", Name = "France" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), CountryCode = "POL", Name = "Poland" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), CountryCode = "RUS", Name = "Russia" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), CountryCode = "NLD", Name = "Netherlands" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), CountryCode = "AUT", Name = "Austria" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), CountryCode = "ROM", Name = "Romania" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), CountryCode = "CAN", Name = "Canada" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), CountryCode = "CHN", Name = "China" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000015"), CountryCode = "CZE", Name = "Czech Republic" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000016"), CountryCode = "MAC", Name = "Macedonia" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000017"), CountryCode = "THA", Name = "Thailand" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000018"), CountryCode = "IND", Name = "India" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000019"), CountryCode = "JPN", Name = "Japan" },
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000020"), CountryCode = "SWE", Name = "Sweden" }
                );
        }
    }
}
