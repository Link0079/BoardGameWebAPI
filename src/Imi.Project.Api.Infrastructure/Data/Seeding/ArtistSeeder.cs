using Imi.Project.Api.Core.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class ArtistSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
            #region Artists
                new Artist { Id = Guid.Parse("00000000-0001-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000001"), Dob = new DateTime(1958, 12, 19), Name = "Ludovic Roudy" },
                new Artist { Id = Guid.Parse("00000000-0002-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000020"), Dob = new DateTime(1963, 07, 14), Name = "Alexandr Elichev" },
                new Artist { Id = Guid.Parse("00000000-0003-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000009"), Dob = new DateTime(1979, 02, 09), Name = "Alvaro Nebot" },
                new Artist { Id = Guid.Parse("00000000-0004-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000013"), Dob = new DateTime(1989, 12, 28), Name = "Josh T. McDowell" },
                new Artist { Id = Guid.Parse("00000000-0005-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Dob = new DateTime(1994, 09, 23), Name = "Isaac Fryxelius" },
                new Artist { Id = Guid.Parse("00000000-0006-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000001"), Dob = new DateTime(1966, 05, 18), Name = "Kyle Ferrin" },
                new Artist { Id = Guid.Parse("00000000-0007-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Dob = new DateTime(1956, 12, 13), Name = "Clay Brooks" },
                new Artist { Id = Guid.Parse("00000000-0008-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000003"), Dob = new DateTime(1951, 10, 08), Name = "Raul Ramous" },
                new Artist { Id = Guid.Parse("00000000-0009-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Dob = new DateTime(1969, 07, 27), Name = "Nate Storm" },
                new Artist { Id = Guid.Parse("00000000-0010-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000013"), Dob = new DateTime(1987, 04, 22), Name = "Ryan Laukat" },
                new Artist { Id = Guid.Parse("00000000-0011-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000016"), Dob = new DateTime(1994, 11, 17), Name = "Christopher Hosch" },
                new Artist { Id = Guid.Parse("00000000-0012-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000009"), Dob = new DateTime(1964, 08, 12), Name = "Marcin Jakubowski" },
                new Artist { Id = Guid.Parse("00000000-0013-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000011"), Dob = new DateTime(1977, 05, 07), Name = "Ignacio Bazan Lazcano" },
                new Artist { Id = Guid.Parse("00000000-0014-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000003"), Dob = new DateTime(1985, 02, 27), Name = "Ana Maria Martinez Jaramillo" },
                new Artist { Id = Guid.Parse("00000000-0015-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000003"), Dob = new DateTime(1992, 10, 26), Name = "Natalia Rojas" },
                new Artist { Id = Guid.Parse("00000000-0016-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000006"), Dob = new DateTime(1999, 07, 21), Name = "Beth Sobel" },
                new Artist { Id = Guid.Parse("00000000-0017-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Dob = new DateTime(1950, 04, 16), Name = "Andrew Bosley" },
                new Artist { Id = Guid.Parse("00000000-0018-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Dob = new DateTime(1963, 01, 11), Name = "Cody Jones" },
                new Artist { Id = Guid.Parse("00000000-0019-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Dob = new DateTime(1972, 12, 06), Name = "Dann May" },
                new Artist { Id = Guid.Parse("00000000-0020-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000012"), Dob = new DateTime(1983, 10, 29), Name = "Cristi Balancescu" },
                new Artist { Id = Guid.Parse("00000000-0021-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Dob = new DateTime(1996, 08, 25), Name = "Yoann Boissonnet" },
                new Artist { Id = Guid.Parse("00000000-0022-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Dob = new DateTime(1997, 06, 20), Name = "Anders Finer" },
                new Artist { Id = Guid.Parse("00000000-0023-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000003"), Dob = new DateTime(1989, 04, 15), Name = "Milan Vavron" },
                new Artist { Id = Guid.Parse("00000000-0024-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000011"), Dob = new DateTime(1982, 02, 10), Name = "Chris Raimo" },
                new Artist { Id = Guid.Parse("00000000-0025-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Dob = new DateTime(1985, 11, 05), Name = "J. Lonnee" },
                new Artist { Id = Guid.Parse("00000000-0026-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Dob = new DateTime(1961, 09, 29), Name = "Sebastian Koziner" },
                new Artist { Id = Guid.Parse("00000000-0027-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000003"), Dob = new DateTime(1981, 07, 24), Name = "Sabrina Miramon" },
                new Artist { Id = Guid.Parse("00000000-0028-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Dob = new DateTime(1970, 05, 19), Name = "Chris Quilliams" },
                new Artist { Id = Guid.Parse("00000000-0029-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Dob = new DateTime(1979, 03, 14), Name = "Josh J. Carlson" },
                new Artist { Id = Guid.Parse("00000000-0030-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Dob = new DateTime(1960, 01, 09), Name = "Anthony LeTourneau" },
                new Artist { Id = Guid.Parse("00000000-0031-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000002"), Dob = new DateTime(1968, 12, 04), Name = "Martin Hoffmann" },
                new Artist { Id = Guid.Parse("00000000-0032-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Dob = new DateTime(1953, 11, 28), Name = "Claus Stephan" },
                new Artist { Id = Guid.Parse("00000000-0033-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000019"), Dob = new DateTime(1988, 10, 23), Name = "Mirko Suzuki" },
                new Artist { Id = Guid.Parse("00000000-0034-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000010"), Dob = new DateTime(1959, 09, 18), Name = "Dennis Lohausen" },
                new Artist { Id = Guid.Parse("00000000-0035-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000006"), Dob = new DateTime(1980, 08, 13), Name = "John Howe" },
                new Artist { Id = Guid.Parse("00000000-0036-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000003"), Dob = new DateTime(1955, 07, 08), Name = "Fabio Maiorana" },
                new Artist { Id = Guid.Parse("00000000-0037-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Dob = new DateTime(1976, 11, 03), Name = "Jason Behnke" },
                new Artist { Id = Guid.Parse("00000000-0038-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Dob = new DateTime(1969, 06, 27), Name = "Loic Berger" },
                new Artist { Id = Guid.Parse("00000000-0039-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Dob = new DateTime(1990, 10, 22), Name = "Loic Billiau" },
                new Artist { Id = Guid.Parse("00000000-0040-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Dob = new DateTime(1957, 05, 17), Name = "Stephane Gatiez" },
                new Artist { Id = Guid.Parse("00000000-0041-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000015"), Dob = new DateTime(1975, 09, 12), Name = "Tomas Kucerovsky" },
                new Artist { Id = Guid.Parse("00000000-0042-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Dob = new DateTime(1992, 04, 07), Name = "Filip Murmak" },
                new Artist { Id = Guid.Parse("00000000-0043-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000017"), Dob = new DateTime(1958, 08, 02), Name = "Nan Rangsima" },
                new Artist { Id = Guid.Parse("00000000-0044-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Dob = new DateTime(1962, 03, 29), Name = "Fabien Fulchiron" },
                new Artist { Id = Guid.Parse("00000000-0045-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Dob = new DateTime(1972, 12, 25), Name = "Manuel Sanchez" },
                new Artist { Id = Guid.Parse("00000000-0046-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000011"), Dob = new DateTime(1982, 07, 20), Name = "Klemens Franz" },
                new Artist { Id = Guid.Parse("00000000-0047-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000011"), Dob = new DateTime(1992, 02, 15), Name = "Alexander Pfister" },
                new Artist { Id = Guid.Parse("00000000-0048-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000002"), Dob = new DateTime(1955, 10, 10), Name = "Andreas Resch" },
                new Artist { Id = Guid.Parse("00000000-0049-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Dob = new DateTime(1965, 05, 05), Name = "Michal Oracz" },
                new Artist { Id = Guid.Parse("00000000-0050-0000-0000-000000000000"), CountryId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Dob = new DateTime(1975, 01, 01), Name = "Ewa Labak" }
                #endregion
                );

        }
    }
}
