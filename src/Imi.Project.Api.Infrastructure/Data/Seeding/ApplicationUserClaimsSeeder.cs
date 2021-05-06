using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public static class ApplicationUserClaimsSeeder
    {
        public static void Seeding(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserClaim<Guid>>().HasData(
            #region RegistrationClaims        
                new IdentityUserClaim<Guid> { Id = 1, UserId = Guid.Parse("00000000-0000-0000-0000-100000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2015, 01, 01).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 2, UserId = Guid.Parse("00000000-0000-0000-0000-200000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2015, 02, 01).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 3, UserId = Guid.Parse("00000000-0000-0000-0000-300000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2020, 03, 01).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 4, UserId = Guid.Parse("00000000-0000-0000-0000-400000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2019, 04, 01).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 5, UserId = Guid.Parse("00000000-0000-0000-0000-500000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2018, 05, 02).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 6, UserId = Guid.Parse("00000000-0000-0000-0000-600000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2019, 06, 03).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 7, UserId = Guid.Parse("00000000-0000-0000-0000-700000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2020, 07, 04).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 8, UserId = Guid.Parse("00000000-0000-0000-0000-800000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2021, 08, 05).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 9, UserId = Guid.Parse("00000000-0000-0000-0000-900000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2020, 09, 06).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 10, UserId = Guid.Parse("00000000-0000-0000-0000-110000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2019, 10, 07).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 11, UserId = Guid.Parse("00000000-0000-0000-0000-120000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2018, 11, 08).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 12, UserId = Guid.Parse("00000000-0000-0000-0000-130000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2019, 12, 09).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 13, UserId = Guid.Parse("00000000-0000-0000-0000-140000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2020, 01, 10).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 14, UserId = Guid.Parse("00000000-0000-0000-0000-150000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2021, 02, 11).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 15, UserId = Guid.Parse("00000000-0000-0000-0000-160000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2020, 03, 12).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 16, UserId = Guid.Parse("00000000-0000-0000-0000-170000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2019, 04, 13).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 17, UserId = Guid.Parse("00000000-0000-0000-0000-180000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2018, 05, 14).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 18, UserId = Guid.Parse("00000000-0000-0000-0000-190000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2019, 06, 15).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 19, UserId = Guid.Parse("00000000-0000-0000-0000-210000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2020, 07, 16).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 20, UserId = Guid.Parse("00000000-0000-0000-0000-220000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2021, 08, 17).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 21, UserId = Guid.Parse("00000000-0000-0000-0000-230000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2020, 09, 18).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 22, UserId = Guid.Parse("00000000-0000-0000-0000-240000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2019, 10, 19).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 23, UserId = Guid.Parse("00000000-0000-0000-0000-250000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2018, 11, 20).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 24, UserId = Guid.Parse("00000000-0000-0000-0000-260000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2019, 12, 21).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 25, UserId = Guid.Parse("00000000-0000-0000-0000-270000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2020, 01, 22).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 26, UserId = Guid.Parse("00000000-0000-0000-0000-280000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2021, 02, 23).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 27, UserId = Guid.Parse("00000000-0000-0000-0000-290000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2020, 03, 24).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 28, UserId = Guid.Parse("00000000-0000-0000-0000-310000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2019, 04, 25).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 29, UserId = Guid.Parse("00000000-0000-0000-0000-320000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2018, 05, 26).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 30, UserId = Guid.Parse("00000000-0000-0000-0000-330000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2019, 06, 27).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> { Id = 31, UserId = Guid.Parse("00000000-0000-0000-0000-340000000000"), ClaimType = "registration-date", ClaimValue = new DateTime(2020, 07, 28).ToString("yyyy-MM-dd") },
            #endregion

            #region Dob Claims
                new IdentityUserClaim<Guid> { Id = 32, UserId = Guid.Parse("00000000-0000-0000-0000-100000000000"), ClaimType = "dob", ClaimValue = new DateTime(1988, 02, 09).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 33, UserId = Guid.Parse("00000000-0000-0000-0000-200000000000"), ClaimType = "dob", ClaimValue = new DateTime(1990, 05, 15).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 34, UserId = Guid.Parse("00000000-0000-0000-0000-300000000000"), ClaimType = "dob", ClaimValue = new DateTime(1997, 01, 15).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 35, UserId = Guid.Parse("00000000-0000-0000-0000-400000000000"), ClaimType = "dob", ClaimValue = new DateTime(1981, 08, 04).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 36, UserId = Guid.Parse("00000000-0000-0000-0000-500000000000"), ClaimType = "dob", ClaimValue = new DateTime(1985, 11, 30).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 37, UserId = Guid.Parse("00000000-0000-0000-0000-600000000000"), ClaimType = "dob", ClaimValue = new DateTime(1973, 03, 24).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 38, UserId = Guid.Parse("00000000-0000-0000-0000-700000000000"), ClaimType = "dob", ClaimValue = new DateTime(1975, 04, 30).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 39, UserId = Guid.Parse("00000000-0000-0000-0000-800000000000"), ClaimType = "dob", ClaimValue = new DateTime(1981, 04, 30).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 40, UserId = Guid.Parse("00000000-0000-0000-0000-900000000000"), ClaimType = "dob", ClaimValue = new DateTime(1980, 06, 23).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 41, UserId = Guid.Parse("00000000-0000-0000-0000-110000000000"), ClaimType = "dob", ClaimValue = new DateTime(1980, 06, 23).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 42, UserId = Guid.Parse("00000000-0000-0000-0000-120000000000"), ClaimType = "dob", ClaimValue = new DateTime(1973, 12, 12).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 43, UserId = Guid.Parse("00000000-0000-0000-0000-130000000000"), ClaimType = "dob", ClaimValue = new DateTime(1972, 01, 22).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 44, UserId = Guid.Parse("00000000-0000-0000-0000-140000000000"), ClaimType = "dob", ClaimValue = new DateTime(1981, 08, 04).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 45, UserId = Guid.Parse("00000000-0000-0000-0000-150000000000"), ClaimType = "dob", ClaimValue = new DateTime(1981, 08, 27).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 46, UserId = Guid.Parse("00000000-0000-0000-0000-160000000000"), ClaimType = "dob", ClaimValue = new DateTime(1972, 12, 06).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 47, UserId = Guid.Parse("00000000-0000-0000-0000-170000000000"), ClaimType = "dob", ClaimValue = new DateTime(1970, 06, 12).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 48, UserId = Guid.Parse("00000000-0000-0000-0000-180000000000"), ClaimType = "dob", ClaimValue = new DateTime(1956, 04, 18).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 49, UserId = Guid.Parse("00000000-0000-0000-0000-190000000000"), ClaimType = "dob", ClaimValue = new DateTime(1990, 07, 02).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 50, UserId = Guid.Parse("00000000-0000-0000-0000-210000000000"), ClaimType = "dob", ClaimValue = new DateTime(1986, 05, 17).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 51, UserId = Guid.Parse("00000000-0000-0000-0000-220000000000"), ClaimType = "dob", ClaimValue = new DateTime(1979, 04, 22).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 52, UserId = Guid.Parse("00000000-0000-0000-0000-230000000000"), ClaimType = "dob", ClaimValue = new DateTime(1985, 09, 24).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 53, UserId = Guid.Parse("00000000-0000-0000-0000-240000000000"), ClaimType = "dob", ClaimValue = new DateTime(1983, 04, 10).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 54, UserId = Guid.Parse("00000000-0000-0000-0000-250000000000"), ClaimType = "dob", ClaimValue = new DateTime(1999, 06, 21).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 55, UserId = Guid.Parse("00000000-0000-0000-0000-260000000000"), ClaimType = "dob", ClaimValue = new DateTime(1986, 04, 22).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 56, UserId = Guid.Parse("00000000-0000-0000-0000-270000000000"), ClaimType = "dob", ClaimValue = new DateTime(1986, 05, 16).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 57, UserId = Guid.Parse("00000000-0000-0000-0000-280000000000"), ClaimType = "dob", ClaimValue = new DateTime(1975, 05, 16).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 58, UserId = Guid.Parse("00000000-0000-0000-0000-290000000000"), ClaimType = "dob", ClaimValue = new DateTime(1980, 05, 16).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 59, UserId = Guid.Parse("00000000-0000-0000-0000-310000000000"), ClaimType = "dob", ClaimValue = new DateTime(1980, 05, 16).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 60, UserId = Guid.Parse("00000000-0000-0000-0000-320000000000"), ClaimType = "dob", ClaimValue = new DateTime(1980, 05, 16).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 61, UserId = Guid.Parse("00000000-0000-0000-0000-330000000000"), ClaimType = "dob", ClaimValue = new DateTime(1975, 05, 16).ToString("yyyy-MM-dd") },
                new IdentityUserClaim<Guid> {Id = 62, UserId = Guid.Parse("00000000-0000-0000-0000-340000000000"), ClaimType = "dob", ClaimValue = new DateTime(1980, 05, 16).ToString("yyyy-MM-dd") },
            #endregion

            #region FirstNameChar        
                new IdentityUserClaim<Guid> { Id = 63, UserId = Guid.Parse("00000000-0000-0000-0000-100000000000"), ClaimType = "firstnamechar", ClaimValue = "B" },
                new IdentityUserClaim<Guid> {Id = 64, UserId = Guid.Parse("00000000-0000-0000-0000-200000000000"), ClaimType = "firstnamechar", ClaimValue = "S" },
                new IdentityUserClaim<Guid> {Id = 65, UserId = Guid.Parse("00000000-0000-0000-0000-300000000000"), ClaimType = "firstnamechar", ClaimValue = "A" },
                new IdentityUserClaim<Guid> {Id = 66, UserId = Guid.Parse("00000000-0000-0000-0000-400000000000"), ClaimType = "firstnamechar", ClaimValue = "A" },
                new IdentityUserClaim<Guid> {Id = 67, UserId = Guid.Parse("00000000-0000-0000-0000-500000000000"), ClaimType = "firstnamechar", ClaimValue = "K" },
                new IdentityUserClaim<Guid> {Id = 68, UserId = Guid.Parse("00000000-0000-0000-0000-600000000000"), ClaimType = "firstnamechar", ClaimValue = "J" },
                new IdentityUserClaim<Guid> {Id = 69, UserId = Guid.Parse("00000000-0000-0000-0000-700000000000"), ClaimType = "firstnamechar", ClaimValue = "J" },
                new IdentityUserClaim<Guid> {Id = 70, UserId = Guid.Parse("00000000-0000-0000-0000-800000000000"), ClaimType = "firstnamechar", ClaimValue = "K" },
                new IdentityUserClaim<Guid> {Id = 71, UserId = Guid.Parse("00000000-0000-0000-0000-900000000000"), ClaimType = "firstnamechar", ClaimValue = "S" },
                new IdentityUserClaim<Guid> {Id = 72, UserId = Guid.Parse("00000000-0000-0000-0000-110000000000"), ClaimType = "firstnamechar", ClaimValue = "M" },
                new IdentityUserClaim<Guid> {Id = 73, UserId = Guid.Parse("00000000-0000-0000-0000-120000000000"), ClaimType = "firstnamechar", ClaimValue = "M" },
                new IdentityUserClaim<Guid> {Id = 74, UserId = Guid.Parse("00000000-0000-0000-0000-130000000000"), ClaimType = "firstnamechar", ClaimValue = "G" },
                new IdentityUserClaim<Guid> {Id = 75, UserId = Guid.Parse("00000000-0000-0000-0000-140000000000"), ClaimType = "firstnamechar", ClaimValue = "M" },
                new IdentityUserClaim<Guid> {Id = 76, UserId = Guid.Parse("00000000-0000-0000-0000-150000000000"), ClaimType = "firstnamechar", ClaimValue = "P" },
                new IdentityUserClaim<Guid> {Id = 77, UserId = Guid.Parse("00000000-0000-0000-0000-160000000000"), ClaimType = "firstnamechar", ClaimValue = "S" },
                new IdentityUserClaim<Guid> {Id = 78, UserId = Guid.Parse("00000000-0000-0000-0000-170000000000"), ClaimType = "firstnamechar", ClaimValue = "R" },
                new IdentityUserClaim<Guid> {Id = 79, UserId = Guid.Parse("00000000-0000-0000-0000-180000000000"), ClaimType = "firstnamechar", ClaimValue = "E" },
                new IdentityUserClaim<Guid> {Id = 80, UserId = Guid.Parse("00000000-0000-0000-0000-190000000000"), ClaimType = "firstnamechar", ClaimValue = "M" },
                new IdentityUserClaim<Guid> {Id = 81, UserId = Guid.Parse("00000000-0000-0000-0000-210000000000"), ClaimType = "firstnamechar", ClaimValue = "E" },
                new IdentityUserClaim<Guid> {Id = 82, UserId = Guid.Parse("00000000-0000-0000-0000-220000000000"), ClaimType = "firstnamechar", ClaimValue = "M" },
                new IdentityUserClaim<Guid> {Id = 83, UserId = Guid.Parse("00000000-0000-0000-0000-230000000000"), ClaimType = "firstnamechar", ClaimValue = "J" },
                new IdentityUserClaim<Guid> {Id = 84, UserId = Guid.Parse("00000000-0000-0000-0000-240000000000"), ClaimType = "firstnamechar", ClaimValue = "J" },
                new IdentityUserClaim<Guid> {Id = 85, UserId = Guid.Parse("00000000-0000-0000-0000-250000000000"), ClaimType = "firstnamechar", ClaimValue = "N" },
                new IdentityUserClaim<Guid> {Id = 86, UserId = Guid.Parse("00000000-0000-0000-0000-260000000000"), ClaimType = "firstnamechar", ClaimValue = "A" },
                new IdentityUserClaim<Guid> {Id = 87, UserId = Guid.Parse("00000000-0000-0000-0000-270000000000"), ClaimType = "firstnamechar", ClaimValue = "M" },
                new IdentityUserClaim<Guid> {Id = 88, UserId = Guid.Parse("00000000-0000-0000-0000-280000000000"), ClaimType = "firstnamechar", ClaimValue = "S" },
                new IdentityUserClaim<Guid> {Id = 89, UserId = Guid.Parse("00000000-0000-0000-0000-290000000000"), ClaimType = "firstnamechar", ClaimValue = "M" },
                new IdentityUserClaim<Guid> {Id = 90, UserId = Guid.Parse("00000000-0000-0000-0000-310000000000"), ClaimType = "firstnamechar", ClaimValue = "J" },
                new IdentityUserClaim<Guid> {Id = 91, UserId = Guid.Parse("00000000-0000-0000-0000-320000000000"), ClaimType = "firstnamechar", ClaimValue = "S" },
                new IdentityUserClaim<Guid> {Id = 92, UserId = Guid.Parse("00000000-0000-0000-0000-330000000000"), ClaimType = "firstnamechar", ClaimValue = "W" },
                new IdentityUserClaim<Guid> {Id = 93, UserId = Guid.Parse("00000000-0000-0000-0000-340000000000"), ClaimType = "firstnamechar", ClaimValue = "M" } 
                #endregion
            );
        }
    }
}
