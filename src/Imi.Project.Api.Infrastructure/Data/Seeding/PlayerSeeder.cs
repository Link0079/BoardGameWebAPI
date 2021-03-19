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
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-200000000000"),
                    Name = "Sofie Brauwers",
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-300000000000"),
                    Name = "Athena Faris",
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-400000000000"),
                    Name = "Abigail Spencer",
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                },
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-500000000000"),
                    Name = "Kaley Cuoco",
                    //CountryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    IsDeleted = false
                }
                #endregion
                );

        }

    }
}
