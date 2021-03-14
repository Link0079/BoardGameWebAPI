using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class CategorySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = Guid.Parse("00000000-0000-0000-0001-000000000000"), Name = "Puzzle Games" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0002-000000000000"), Name = "Card Games" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0003-000000000000"), Name = "Party Games" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0004-000000000000"), Name = "Dice Games" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0005-000000000000"), Name = "Roll and Write Games" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0006-000000000000"), Name = "Fantasy Games" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0007-000000000000"), Name = "Base Building Games" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0008-000000000000"), Name = "Animal Games" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0009-000000000000"), Name = "Horror Games" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0010-000000000000"), Name = "Miniature Games" }
                );
        }
    }
}
