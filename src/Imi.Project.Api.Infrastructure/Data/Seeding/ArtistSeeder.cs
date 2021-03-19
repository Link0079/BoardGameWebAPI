using Imi.Project.Api.Core.Entities;
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
                new Artist
                {
                    Id = Guid.Parse("00000000-0001-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000001"), 
                    Dob = new DateTime(1958, 12, 19),
                    IsDeleted = false,
                    Name = "Ludovic Roudy"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0002-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000020"), 
                    Dob = new DateTime(1963, 07, 14),
                    IsDeleted = false,
                    Name = "Alexandr Elichev"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0003-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000009"), 
                    Dob = new DateTime(1979, 02, 09),
                    IsDeleted = false,
                    Name = "Alvaro Nebot"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0004-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000013"), 
                    Dob = new DateTime(1989, 12, 28),
                    IsDeleted = false,
                    Name = "Josh T. McDowell"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0005-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), 
                    Dob = new DateTime(1994, 09, 23),
                    IsDeleted = false,
                    Name = "Isaac Fryxelius"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0006-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000001"), 
                    Dob = new DateTime(1966, 05, 18),
                    IsDeleted = false,
                    Name = "Kyle Ferrin"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0007-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000005"), 
                    Dob = new DateTime(1956, 12, 13),
                    IsDeleted = false,
                    Name = "Clay Brooks"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0008-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000003"), 
                    Dob = new DateTime(1951, 10, 08),
                    IsDeleted = false,
                    Name = "Raul Ramous"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0009-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), 
                    Dob = new DateTime(1969, 07, 27),
                    IsDeleted = false,
                    Name = "Nate Storm"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0010-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000013"), 
                    Dob = new DateTime(1987, 04, 22),
                    IsDeleted = false,
                    Name = "Ryan Laukat"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0011-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000016"), 
                    Dob = new DateTime(1994, 11, 17),
                    IsDeleted = false,
                    Name = "Christopher Hosch"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0012-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000009"), 
                    Dob = new DateTime(1964, 08, 12),
                    IsDeleted = false,
                    Name = "Marcin Jakubowski"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0013-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000011"), 
                    Dob = new DateTime(1977, 05, 07),
                    IsDeleted = false,
                    Name = "Ignacio Bazan Lazcano"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0014-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000003"), 
                    Dob = new DateTime(1985, 02, 27),
                    IsDeleted = false,
                    Name = "Ana Maria Martinez Jaramillo"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0015-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000003"), 
                    Dob = new DateTime(1992, 10, 26),
                    IsDeleted = false,
                    Name = "Natalia Rojas"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0016-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000006"), 
                    Dob = new DateTime(1999, 07, 21),
                    IsDeleted = false,
                    Name = "Beth Sobel"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0017-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000005"), 
                    Dob = new DateTime(1950, 04, 16),
                    IsDeleted = false,
                    Name = "Andrew Bosley"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0018-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), 
                    Dob = new DateTime(1963, 01, 11),
                    IsDeleted = false,
                    Name = "Cody Jones"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0019-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), 
                    Dob = new DateTime(1972, 12, 06),
                    IsDeleted = false,
                    Name = "Dann May"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0020-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000012"), 
                    Dob = new DateTime(1983, 10, 29),
                    IsDeleted = false,
                    Name = "Cristi Balancescu"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0021-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), 
                    Dob = new DateTime(1996, 08, 25),
                    IsDeleted = false,
                    Name = "Yoann Boissonnet"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0022-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000005"), 
                    Dob = new DateTime(1997, 06, 20),
                    IsDeleted = false,
                    Name = "Anders Finer"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0023-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000003"), 
                    Dob = new DateTime(1989, 04, 15),
                    IsDeleted = false,
                    Name = "Milan Vavron"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0024-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000011"), 
                    Dob = new DateTime(1982, 02, 10),
                    IsDeleted = false,
                    Name = "Chris Raimo"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0025-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), 
                    Dob = new DateTime(1985, 11, 05),
                    IsDeleted = false,
                    Name = "J. Lonnee"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0026-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000008"), 
                    Dob = new DateTime(1961, 09, 29),
                    IsDeleted = false,
                    Name = "Sebastian Koziner"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0027-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000003"), 
                    Dob = new DateTime(1981, 07, 24),
                    IsDeleted = false,
                    Name = "Sabrina Miramon"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0028-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), 
                    Dob = new DateTime(1970, 05, 19),
                    IsDeleted = false,
                    Name = "Chris Quilliams"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0029-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000005"), 
                    Dob = new DateTime(1979, 03, 14),
                    IsDeleted = false,
                    Name = "Josh J. Carlson"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0030-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), 
                    Dob = new DateTime(1960, 01, 09),
                    IsDeleted = false,
                    Name = "Anthony LeTourneau"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0031-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000002"), 
                    Dob = new DateTime(1968, 12, 04),
                    IsDeleted = false,
                    Name = "Martin Hoffmann"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0032-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), 
                    Dob = new DateTime(1953, 11, 28),
                    IsDeleted = false,
                    Name = "Claus Stephan"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0033-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000019"), 
                    Dob = new DateTime(1988, 10, 23),
                    IsDeleted = false,
                    Name = "Mirko Suzuki"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0034-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000010"), 
                    Dob = new DateTime(1959, 09, 18),
                    IsDeleted = false,
                    Name = "Dennis Lohausen"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0035-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000006"), 
                    Dob = new DateTime(1980, 08, 13),
                    IsDeleted = false,
                    Name = "John Howe"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0036-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000003"), 
                    Dob = new DateTime(1955, 07, 08),
                    IsDeleted = false,
                    Name = "Fabio Maiorana"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0037-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), 
                    Dob = new DateTime(1976, 11, 03),
                    IsDeleted = false,
                    Name = "Jason Behnke"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0038-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), 
                    Dob = new DateTime(1969, 06, 27),
                    IsDeleted = false,
                    Name = "Loic Berger"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0039-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), 
                    Dob = new DateTime(1990, 10, 22),
                    IsDeleted = false,
                    Name = "Loic Billiau"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0040-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), 
                    Dob = new DateTime(1957, 05, 17),
                    IsDeleted = false,
                    Name = "Stephane Gatiez"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0041-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000015"), 
                    Dob = new DateTime(1975, 09, 12),
                    IsDeleted = false,
                    Name = "Tomas Kucerovsky"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0042-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), 
                    Dob = new DateTime(1992, 04, 07),
                    IsDeleted = false,
                    Name = "Filip Murmak"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0043-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000017"), 
                    Dob = new DateTime(1958, 08, 02),
                    IsDeleted = false,
                    Name = "Nan Rangsima"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0044-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), 
                    Dob = new DateTime(1962, 03, 29),
                    IsDeleted = false,
                    Name = "Fabien Fulchiron"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0045-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000007"), 
                    Dob = new DateTime(1972, 12, 25),
                    IsDeleted = false,
                    Name = "Manuel Sanchez"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0046-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000011"), 
                    Dob = new DateTime(1982, 07, 20),
                    IsDeleted = false,
                    Name = "Klemens Franz"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0047-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000011"), 
                    Dob = new DateTime(1992, 02, 15),
                    IsDeleted = false,
                    Name = "Alexander Pfister"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0048-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000002"), 
                    Dob = new DateTime(1955, 10, 10),
                    IsDeleted = false,
                    Name = "Andreas Resch"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0049-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000008"), 
                    Dob = new DateTime(1965, 05, 05),
                    IsDeleted = false,
                    Name = "Michal Oracz"
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0050-0000-0000-000000000000"),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000008"), 
                    Dob = new DateTime(1975, 01, 01),
                    IsDeleted = false,
                    Name = "Ewa Labak"
                }
                #endregion
                );

        }
    }
}
