using Imi.Project.Api.Core.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public static class ApplicationRoleSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationRole>().HasData(
                new ApplicationRole
                {
                    Id = Guid.Parse("00000001-0000-0000-0000-000000000000"),
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new ApplicationRole
                {
                    Id = Guid.Parse("00000002-0000-0000-0000-000000000000"),
                    Name = "Player",
                    NormalizedName = "PLAYER"
                },
                new ApplicationRole
                {
                    Id = Guid.Parse("00000003-0000-0000-0000-000000000000"),
                    Name = "BoardGameEditor",
                    NormalizedName = "BOARDGAMEEDITOR"
                },
                new ApplicationRole
                {
                    Id = Guid.Parse("00000004-0000-0000-0000-000000000000"),
                    Name = "ArtistEditor",
                    NormalizedName = "ARTISTEDITOR"
                }
            );
        }
    }
}
