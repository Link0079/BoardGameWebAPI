using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public static class ApplicationUserRoleSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
            #region Admins
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000001-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-100000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000001-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-200000000000") },
            #endregion

            #region BoardGameEditors
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000003-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-300000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000003-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-400000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000003-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-500000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000003-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-600000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000003-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-700000000000") },
            #endregion

            #region Players
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-800000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-900000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-110000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-120000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-130000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-140000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-150000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-160000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-170000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-180000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-190000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-210000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-220000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-230000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-240000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-250000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-260000000000") },
                new IdentityUserRole<Guid> { RoleId = Guid.Parse("00000002-0000-0000-0000-000000000000"), UserId = Guid.Parse("00000000-0000-0000-0000-270000000000") }
                #endregion
            );
        }
    }
}
