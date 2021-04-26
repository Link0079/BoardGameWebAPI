using Imi.Project.Api.Core.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class PlayerSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasData(
            #region Players
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-100000000000"),
                    Name = "Bjorn Vossen",
                    Dob = new DateTime(1988, 02, 09),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-200000000000"),
                    Name = "Sofie Brauwers",
                    Dob = new DateTime(1990, 05, 15),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-300000000000"),
                    Name = "Athena Faris",
                    Dob = new DateTime(1997, 01, 15),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-400000000000"),
                    Name = "Abigail Spencer",
                    Dob = new DateTime(1981, 08, 04),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-500000000000"),
                    Name = "Kaley Cuoco",
                    Dob = new DateTime(1985, 11, 30),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-600000000000"),
                    Name = "Jim Parsons",
                    Dob = new DateTime(1973, 03, 24),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-700000000000"),
                    Name = "Johnny Galecki",
                    Dob = new DateTime(1975, 04, 30),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-800000000000"),
                    Name = "Kunal Nayyar",
                    Dob = new DateTime(1981, 04, 30),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-900000000000"),
                    Name = "Simon Helberg",
                    Dob = new DateTime(1980, 06, 23),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-110000000000"),
                    Name = "Melissa Rauch",
                    Dob = new DateTime(1980, 06, 23),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-120000000000"),
                    Name = "Mayim Bialik",
                    Dob = new DateTime(1973, 12, 12),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-130000000000"),
                    Name = "Gabriel Macht",
                    Dob = new DateTime(1972, 01, 22),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-140000000000"),
                    Name = "Megan Markle",
                    Dob = new DateTime(1981, 08, 04),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-150000000000"),
                    Name = "Patrick J. Adams",
                    Dob = new DateTime(1981, 08, 27),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-160000000000"),
                    Name = "Sarah Rafferty",
                    Dob = new DateTime(1972, 12, 06),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-170000000000"),
                    Name = "Rick Hoffman",
                    Dob = new DateTime(1970, 06, 12),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-180000000000"),
                    Name = "Eric Roberts",
                    Dob = new DateTime(1956, 04, 18),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-190000000000"),
                    Name = "Margot Robbie",
                    Dob = new DateTime(1990, 07, 02),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-210000000000"),
                    Name = "Erin Richards",
                    Dob = new DateTime(1986, 05, 17),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-220000000000"),
                    Name = "Morena Baccarin",
                    Dob = new DateTime(1979, 04, 22),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-230000000000"),
                    Name = "Jessica Lucas",
                    Dob = new DateTime(1985, 09, 24),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-240000000000"),
                    Name = "Jamie Chung",
                    Dob = new DateTime(1983, 04, 10),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-250000000000"),
                    Name = "Natalie Alyn Lind",
                    Dob = new DateTime(1999, 06, 21),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-260000000000"),
                    Name = "Amber Heard",
                    Dob = new DateTime(1986, 04, 22),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-270000000000"),
                    Name = "Megan Fox",
                    Dob = new DateTime(1986, 05, 16),
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                }
                #endregion
                );
        }
    }
}
