using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class AddUserClaimsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "020fe52f-f3a0-46c3-b6d1-d4e9279dcf30");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "a61747c0-75df-43b7-96f7-3a42d0385050");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "40e1817d-d1d4-41d2-a172-14db577307ca");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("00000004-0000-0000-0000-000000000000"), "2bb91deb-278d-461d-8cdf-affdef1e6581", "ArtistEditor", "ARTISTEDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 56, "dob", "1986-05-16", new Guid("00000000-0000-0000-0000-270000000000") },
                    { 67, "firstnamechar", "K", new Guid("00000000-0000-0000-0000-500000000000") },
                    { 66, "firstnamechar", "A", new Guid("00000000-0000-0000-0000-400000000000") },
                    { 65, "firstnamechar", "A", new Guid("00000000-0000-0000-0000-300000000000") },
                    { 64, "firstnamechar", "S", new Guid("00000000-0000-0000-0000-200000000000") },
                    { 63, "firstnamechar", "B", new Guid("00000000-0000-0000-0000-100000000000") },
                    { 55, "dob", "1986-04-22", new Guid("00000000-0000-0000-0000-260000000000") },
                    { 53, "dob", "1983-04-10", new Guid("00000000-0000-0000-0000-240000000000") },
                    { 52, "dob", "1985-09-24", new Guid("00000000-0000-0000-0000-230000000000") },
                    { 51, "dob", "1979-04-22", new Guid("00000000-0000-0000-0000-220000000000") },
                    { 50, "dob", "1986-05-17", new Guid("00000000-0000-0000-0000-210000000000") },
                    { 49, "dob", "1990-07-02", new Guid("00000000-0000-0000-0000-190000000000") },
                    { 48, "dob", "1956-04-18", new Guid("00000000-0000-0000-0000-180000000000") },
                    { 47, "dob", "1970-06-12", new Guid("00000000-0000-0000-0000-170000000000") },
                    { 46, "dob", "1972-12-06", new Guid("00000000-0000-0000-0000-160000000000") },
                    { 45, "dob", "1981-08-27", new Guid("00000000-0000-0000-0000-150000000000") },
                    { 68, "firstnamechar", "J", new Guid("00000000-0000-0000-0000-600000000000") },
                    { 69, "firstnamechar", "J", new Guid("00000000-0000-0000-0000-700000000000") },
                    { 70, "firstnamechar", "K", new Guid("00000000-0000-0000-0000-800000000000") },
                    { 71, "firstnamechar", "S", new Guid("00000000-0000-0000-0000-900000000000") },
                    { 87, "firstnamechar", "M", new Guid("00000000-0000-0000-0000-270000000000") },
                    { 86, "firstnamechar", "A", new Guid("00000000-0000-0000-0000-260000000000") },
                    { 85, "firstnamechar", "N", new Guid("00000000-0000-0000-0000-250000000000") },
                    { 84, "firstnamechar", "J", new Guid("00000000-0000-0000-0000-240000000000") },
                    { 83, "firstnamechar", "J", new Guid("00000000-0000-0000-0000-230000000000") },
                    { 82, "firstnamechar", "M", new Guid("00000000-0000-0000-0000-220000000000") },
                    { 81, "firstnamechar", "E", new Guid("00000000-0000-0000-0000-210000000000") },
                    { 44, "dob", "1981-08-04", new Guid("00000000-0000-0000-0000-140000000000") },
                    { 80, "firstnamechar", "M", new Guid("00000000-0000-0000-0000-190000000000") },
                    { 78, "firstnamechar", "R", new Guid("00000000-0000-0000-0000-170000000000") },
                    { 77, "firstnamechar", "S", new Guid("00000000-0000-0000-0000-160000000000") },
                    { 76, "firstnamechar", "P", new Guid("00000000-0000-0000-0000-150000000000") },
                    { 75, "firstnamechar", "M", new Guid("00000000-0000-0000-0000-140000000000") },
                    { 74, "firstnamechar", "G", new Guid("00000000-0000-0000-0000-130000000000") },
                    { 73, "firstnamechar", "M", new Guid("00000000-0000-0000-0000-120000000000") },
                    { 72, "firstnamechar", "M", new Guid("00000000-0000-0000-0000-110000000000") },
                    { 79, "firstnamechar", "E", new Guid("00000000-0000-0000-0000-180000000000") },
                    { 43, "dob", "1972-01-22", new Guid("00000000-0000-0000-0000-130000000000") },
                    { 54, "dob", "1999-06-21", new Guid("00000000-0000-0000-0000-250000000000") },
                    { 41, "dob", "1980-06-23", new Guid("00000000-0000-0000-0000-110000000000") },
                    { 16, "registration-date", "2019-04-13", new Guid("00000000-0000-0000-0000-170000000000") },
                    { 15, "registration-date", "2020-03-12", new Guid("00000000-0000-0000-0000-160000000000") },
                    { 14, "registration-date", "2021-02-11", new Guid("00000000-0000-0000-0000-150000000000") },
                    { 13, "registration-date", "2020-01-10", new Guid("00000000-0000-0000-0000-140000000000") },
                    { 12, "registration-date", "2019-12-09", new Guid("00000000-0000-0000-0000-130000000000") },
                    { 11, "registration-date", "2018-11-08", new Guid("00000000-0000-0000-0000-120000000000") },
                    { 10, "registration-date", "2019-10-07", new Guid("00000000-0000-0000-0000-110000000000") },
                    { 17, "registration-date", "2018-05-14", new Guid("00000000-0000-0000-0000-180000000000") },
                    { 9, "registration-date", "2020-09-06", new Guid("00000000-0000-0000-0000-900000000000") },
                    { 7, "registration-date", "2020-07-04", new Guid("00000000-0000-0000-0000-700000000000") },
                    { 6, "registration-date", "2019-06-03", new Guid("00000000-0000-0000-0000-600000000000") },
                    { 5, "registration-date", "2018-05-02", new Guid("00000000-0000-0000-0000-500000000000") },
                    { 42, "dob", "1973-12-12", new Guid("00000000-0000-0000-0000-120000000000") },
                    { 3, "registration-date", "2020-03-01", new Guid("00000000-0000-0000-0000-300000000000") },
                    { 2, "registration-date", "2015-02-01", new Guid("00000000-0000-0000-0000-200000000000") },
                    { 1, "registration-date", "2015-01-01", new Guid("00000000-0000-0000-0000-100000000000") },
                    { 8, "registration-date", "2021-08-05", new Guid("00000000-0000-0000-0000-800000000000") },
                    { 18, "registration-date", "2019-06-15", new Guid("00000000-0000-0000-0000-190000000000") },
                    { 4, "registration-date", "2019-04-01", new Guid("00000000-0000-0000-0000-400000000000") },
                    { 20, "registration-date", "2021-08-17", new Guid("00000000-0000-0000-0000-220000000000") },
                    { 40, "dob", "1980-06-23", new Guid("00000000-0000-0000-0000-900000000000") },
                    { 39, "dob", "1981-04-30", new Guid("00000000-0000-0000-0000-800000000000") },
                    { 38, "dob", "1975-04-30", new Guid("00000000-0000-0000-0000-700000000000") },
                    { 37, "dob", "1973-03-24", new Guid("00000000-0000-0000-0000-600000000000") },
                    { 36, "dob", "1985-11-30", new Guid("00000000-0000-0000-0000-500000000000") },
                    { 34, "dob", "1997-01-15", new Guid("00000000-0000-0000-0000-300000000000") },
                    { 33, "dob", "1990-05-15", new Guid("00000000-0000-0000-0000-200000000000") },
                    { 35, "dob", "1981-08-04", new Guid("00000000-0000-0000-0000-400000000000") },
                    { 25, "registration-date", "2020-01-22", new Guid("00000000-0000-0000-0000-270000000000") },
                    { 24, "registration-date", "2019-12-21", new Guid("00000000-0000-0000-0000-260000000000") },
                    { 23, "registration-date", "2018-11-20", new Guid("00000000-0000-0000-0000-250000000000") },
                    { 22, "registration-date", "2019-10-19", new Guid("00000000-0000-0000-0000-240000000000") },
                    { 21, "registration-date", "2020-09-18", new Guid("00000000-0000-0000-0000-230000000000") },
                    { 32, "dob", "1988-02-09", new Guid("00000000-0000-0000-0000-100000000000") },
                    { 19, "registration-date", "2020-07-16", new Guid("00000000-0000-0000-0000-210000000000") }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12481995-e017-41d7-a75a-7f2bdc3e5f46", false, "AQAAAAEAACcQAAAAEDEHglMxNvDEmwwiBE3jFEhYDQcRd9GgFl0EptwBu6BEG4KhI3zuQME47GySTale7w==", "35a7802042f042db95b5fe592e165ae2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-110000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae3d79f5-45cc-4ad5-86a5-75ea7640700e", false, "AQAAAAEAACcQAAAAEF6Jl6pIwLrgt6sIIvAchiNFX8kvfqlYZEZM4vkBf5omB1A4qi85AQc0Qd9/tYnXFA==", "c8def3cbe8644b598bea1e130bb43d00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-120000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdb82d7c-7cf4-4310-bad2-aebd70a68eef", false, "AQAAAAEAACcQAAAAELAZTMg6Jak6FGXK5AXpOq+OMS0RP0XZWcM3whhUBhO57CTHOGu+TXDNBZxAWrjQSw==", "f1a135bddb124c66b6939bf3b4f223ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-130000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed44ab0e-1984-45a9-a0df-91f9e3e03836", false, "AQAAAAEAACcQAAAAEIYKRRsqUjoUhVvHmSAajRPkNxtn6yNqqpdvHsE/mwDH+iVIdqulA4njpKQFHzFGUA==", "4d58859a07e644389d2c07dc54e5fab9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-140000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edacbbf4-d927-40ad-92b3-95edfd775c4d", false, "AQAAAAEAACcQAAAAECSqDOZuXIMQYtTuNzaUE3+BOiDSEBgMLhVGJP2qBowEJ1E2W9r3nhPSsxXJC+fUlg==", "4ee7a76106e24f12b6e603dd1502826f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-150000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ad115e6-38c4-454b-866a-c1caac130e87", false, "AQAAAAEAACcQAAAAEF/ptUAqA4me4VUwSZ0ZM8xjp5qweyjeKlPSTBIwDf1H7TSiikbUJ7cNhZvNRtQZyQ==", "12eb42a2bd724a76bde6b2d2d94b296a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-160000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc2ee91e-6ab9-4871-9026-a53411de2167", false, "AQAAAAEAACcQAAAAEDZEdo80/SxflUcmnoEvIuL5idjIUra+uAVyqQfm8a/PT27fEtV8F6anKLzv+59uiA==", "8ea567e7a93948338d30da59312d5e35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-170000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80f09e98-c9af-424e-b57b-3d77a80a048c", false, "AQAAAAEAACcQAAAAEChXvNeoiGv8UccNbOwJLAjw+QoRL29H906+HNkLUhAr/6UqTR4D+D8UreHYgcwQLg==", "5f8b05101b0c4981a31988e063803439" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-180000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57c31c67-3d31-4d9c-b6f6-69e7089403bf", false, "AQAAAAEAACcQAAAAEDM/w+NekpeiXI0SMWYyR3k7wNo1czy1RCI89d5HiR6oMSjbn/ibLcrP3J0ZS6wpKw==", "7627c510da6b4cdeb33001be1ebbe540" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-190000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4303c0b-7c4a-4abe-9ae4-31aa76d4f751", false, "AQAAAAEAACcQAAAAEF/I/8azgp676eEV8j745XFWh6LgYO0ZYiFaHW2gMHpzRCI+D/EIOihHQIp4QEhRew==", "fe0b939ed9d442a797a205c7f471f8b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-200000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29af580f-42db-4a56-a3d6-2d355e89004f", false, "AQAAAAEAACcQAAAAEHSqQc//TBr/nkAqQMpvz7q9cQnMj6T6LAGzid3QGS2ufw/TVDSrk2qWFn1KwHs8Qg==", "039d7a1f87344886a93dd0e8d1f18cde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-210000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0823a96-0786-49e4-b68e-9a0386625083", false, "AQAAAAEAACcQAAAAELzPz8ldmxgmfD6Tm/DGGPkLmpo3Ua5DXoOAAzkvX9gtH03Q6jTu/qZ0wFJWP3IGFQ==", "66975b792e2a431b90e28dea09f767fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-220000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c996916-6dc8-4082-b5bb-37fe6c315778", false, "AQAAAAEAACcQAAAAEGLqgDGYPKfHfnefuIDj5rh3fsfmvMM87mUe91+rNoM0wX+k+KIxD+WAxHpQW3AtJA==", "380ed233a6194c808489f569849550e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-230000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e2e2336-3bb5-4611-8541-33b18179343a", false, "AQAAAAEAACcQAAAAEDVnbYhsjXOMsy14mygMh+lhk8suxD+Sav0kGQ4nrMTvXdBm+urTXZjhhaYDC213qg==", "956374fae6d84276a0530b40e83012ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-240000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d004f08-41e8-4348-a7e8-2e13a15b9200", false, "AQAAAAEAACcQAAAAEIfiuUsMFbPT3+KpRAP91zGszCcZx1nBolbdXCYyfaw5kwnDrtB0SYwdkK9t21YWWQ==", "da2376fa041e481b97d7ff68944b6538" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-250000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dfa197a-2b43-45ba-878f-54f5a57ed220", false, "AQAAAAEAACcQAAAAEJ2DqjAhtGXcvpzdOgpC8QyX1h6Y0ZMXJJWLAF8zSfVBwEOrUg6WmZ3Lkou93rcZtQ==", "009cac5f56ac4baaabc93262f904f4c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-260000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1882cf7e-07a1-4ba3-a641-d690c6b60e26", false, "AQAAAAEAACcQAAAAEDwCkj8JPbb/lYhu2vzOajcwV12mVficQErZXw8F+H9CIX+c4ZgwzMRU/jiT5yXkCA==", "ce363563f2414f738ed56b1469cbcafc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-270000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "078f6fa1-75d1-4e3b-ac2d-ac7217b756ab", false, "AQAAAAEAACcQAAAAEFeqMW9woMRUNo8HTGg/UukjlByZcOd/31lIsEyaQq0tED7Q8/kuoyIMASFezZ8vaw==", "fd41faa18bf849ca92edb293e821ae5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-300000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1bbb786-b6ab-4e9d-8d2f-4a13f721212e", false, "AQAAAAEAACcQAAAAEPh4MTrRXnn+Q87AqBYZjXpjiQKD7VZZs4ZDctTunSqs7zM+9D0Ba74R0Fmtgejahw==", "ebb3c0e3f4b447d4aa4da3d3b032a791" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-400000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8a6a3b3-cd99-4abb-8b75-acb930ad4706", false, "AQAAAAEAACcQAAAAEPg4b3Mimz4yFi1Q06RpSUxLO3dnr2X9uPEHLmwTIXNQxvCfINvUGxI229X3WbclDw==", "742422feb85245339714fa0058f40e4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-500000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e0f5a44-a25d-45ec-beab-4056ddf65289", false, "AQAAAAEAACcQAAAAEC77/tdr8KmwWBhH2h06WBX3x7Dpz7wKBEzoh/QQDXw8vR9nCTqGrgXfNJNUfiRjGA==", "485a07a35aa74b46924f47b76654dc31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-600000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5fbb40e-2634-497a-902a-3c6d045c7c03", false, "AQAAAAEAACcQAAAAEMGTq+8zGg8vFxpEiuHjjzKHSgcDBpe2GtCuiRrCeKQSTmCj76DGtumoaIVmlIRFqQ==", "f71ae99d851845b6aff0aa92886be5ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-700000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d64a8eee-f601-42c5-aea2-4f7dde9e9bc6", false, "AQAAAAEAACcQAAAAEExZgNAAfxgJTC464yCot+9hGmO2xK8mea1BdHQ3u0BbBhba+hbNaMCgizeEFkEbpQ==", "fc60297ee2314452ae53ef0e291b2d5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-800000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e37cdbde-b305-46d1-b35a-d41b9517dc14", false, "AQAAAAEAACcQAAAAEDmIY2cek0Widsb2xX+uZdvbtk6UIvWmVCuP5lNVsWkS/Ezsjqkvyhadd+T4Qfagvw==", "cda4246dda924092b8403101b918768b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-900000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "791bf704-af4d-4fad-af78-78b01613a5c6", false, "AQAAAAEAACcQAAAAEOwel71VtdXmbzJot7hiP+67AE7P16EyAOGYnukZ/gzp+O5nliVVRuiuBjqDIlacXg==", "fabec9876f7745d1a071a9bd6578e691" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-330000000000"), 0, "cbd0dd7c-6cb2-439f-b979-4a50c3d14073", new DateTime(1975, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "William.Scholkkelé@BoardGameWebAPI.com", false, false, false, null, "William Scholkkelé", "WILLIAM.SCHOLKKELÉ@BOARDGAMEWEBAPI.COM", "WILLIAM.SCHOLKKELÉ", "AQAAAAEAACcQAAAAEPRzMZp2OzoEpbdZI9G9/CsuFUeQg+dLwMt1gyR3XsFvdS6qljqjes7K1CAT2SKgeA==", null, false, "e589ebc190814328a538d179bff0f364", false, "William.Scholkkelé" },
                    { new Guid("00000000-0000-0000-0000-340000000000"), 0, "0d75b421-04e2-4164-99b0-db76bb30eeb2", new DateTime(1980, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mileto.Di.Marco@BoardGameWebAPI.com", false, false, false, null, "Mileto Di Marco", "MILETO.DI.MARCO@BOARDGAMEWEBAPI.COM", "MILETO.DI.MARCO", "AQAAAAEAACcQAAAAELCK9odEtuhlwZ+2GTeAOyKW2aj/oMVetcVSpxR2/6psug2F/n9k/8uKwAQdSj7gvw==", null, false, "7d0a79888dcd4266beff2ef2d12dcc86", false, "Mileto.Di.Marco" },
                    { new Guid("00000000-0000-0000-0000-290000000000"), 0, "007a862a-a37f-45a4-aad3-6b5903de02e9", new DateTime(1980, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maxim.Lesy@BoardGameWebAPI.com", false, false, false, null, "Maxim Lesy", "MAXIM.LESY@BOARDGAMEWEBAPI.COM", "MAXIM.LESY", "AQAAAAEAACcQAAAAEKC6gE+vOe8or4iwvnXbtDMUPuZrbRkcgdSXV+8pJuuohelJkbH1Muui3bWrHXKS8w==", null, false, "1325f9bf55a4415e8c9ded35cc8d27b1", false, "Maxim.Lesy" },
                    { new Guid("00000000-0000-0000-0000-310000000000"), 0, "bff5dc47-81b0-495c-8507-2615b14d749d", new DateTime(1980, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joachim.François@BoardGameWebAPI.com", false, false, false, null, "Joachim François", "JOACHIM.FRANÇOIS@BOARDGAMEWEBAPI.COM", "JOACHIM.FRANÇOIS", "AQAAAAEAACcQAAAAEC2ZvVq8V+y2Io3xhr6FklCpx9SPF0tVnFIT1AtfQTv2V+CDYu4We+TZwHZPh6e9zg==", null, false, "deef5bb3b72445269f79446117b0ba93", false, "Joachim.François" },
                    { new Guid("00000000-0000-0000-0000-280000000000"), 0, "7ec29b48-fa06-4b72-9ef0-bd1f1e68a1a2", new DateTime(1975, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stefaan.Vercaemer@BoardGameWebAPI.com", false, false, false, null, "Stefaan Vercaemer", "STEFAAN.VERCAEMER@BOARDGAMEWEBAPI.COM", "STEFAAN.VERCAEMER", "AQAAAAEAACcQAAAAEKHJupQ/Q6R7hLDYtU3x2UDEkWKoqubQJK0DTW0ROWD0VHFg6hNFrBni533NzY8n7w==", null, false, "f076942faf8c4bd38c84f9b06123accc", false, "Stefaan.Vercaemer" },
                    { new Guid("00000000-0000-0000-0000-320000000000"), 0, "a338235b-1678-420e-a93e-009505ef74b2", new DateTime(1980, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Siegried.Derdeyn@BoardGameWebAPI.com", false, false, false, null, "Siegried Derdeyn", "SIEGRIED.DERDEYN@BOARDGAMEWEBAPI.COM", "SIEGRIED.DERDEYN", "AQAAAAEAACcQAAAAENjULu9WtRsxa971f1iBUSScZ2oyGS0BDFXUjw+7tiAFuRM34oHPgwVVsK5u5kOsdw==", null, false, "4aae7559637d42c1ab651d2f7a372e69", false, "Siegried.Derdeyn" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 26, "registration-date", "2021-02-23", new Guid("00000000-0000-0000-0000-280000000000") },
                    { 30, "registration-date", "2019-06-27", new Guid("00000000-0000-0000-0000-330000000000") },
                    { 91, "firstnamechar", "S", new Guid("00000000-0000-0000-0000-320000000000") },
                    { 60, "dob", "1980-05-16", new Guid("00000000-0000-0000-0000-320000000000") },
                    { 29, "registration-date", "2018-05-26", new Guid("00000000-0000-0000-0000-320000000000") },
                    { 93, "firstnamechar", "M", new Guid("00000000-0000-0000-0000-340000000000") },
                    { 90, "firstnamechar", "J", new Guid("00000000-0000-0000-0000-310000000000") },
                    { 61, "dob", "1975-05-16", new Guid("00000000-0000-0000-0000-330000000000") },
                    { 59, "dob", "1980-05-16", new Guid("00000000-0000-0000-0000-310000000000") },
                    { 31, "registration-date", "2020-07-28", new Guid("00000000-0000-0000-0000-340000000000") },
                    { 89, "firstnamechar", "M", new Guid("00000000-0000-0000-0000-290000000000") },
                    { 58, "dob", "1980-05-16", new Guid("00000000-0000-0000-0000-290000000000") },
                    { 27, "registration-date", "2020-03-24", new Guid("00000000-0000-0000-0000-290000000000") },
                    { 62, "dob", "1980-05-16", new Guid("00000000-0000-0000-0000-340000000000") },
                    { 88, "firstnamechar", "S", new Guid("00000000-0000-0000-0000-280000000000") },
                    { 57, "dob", "1975-05-16", new Guid("00000000-0000-0000-0000-280000000000") },
                    { 28, "registration-date", "2019-04-25", new Guid("00000000-0000-0000-0000-310000000000") },
                    { 92, "firstnamechar", "W", new Guid("00000000-0000-0000-0000-330000000000") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-330000000000"), new Guid("00000004-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-310000000000"), new Guid("00000004-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-290000000000"), new Guid("00000004-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-280000000000"), new Guid("00000004-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-320000000000"), new Guid("00000004-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-340000000000"), new Guid("00000004-0000-0000-0000-000000000000") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-280000000000"), new Guid("00000004-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-290000000000"), new Guid("00000004-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-310000000000"), new Guid("00000004-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-320000000000"), new Guid("00000004-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-330000000000"), new Guid("00000004-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-340000000000"), new Guid("00000004-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-280000000000"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-290000000000"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-310000000000"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-320000000000"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-330000000000"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-340000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "47b74fd4-d691-46ba-8638-6af806a7bea5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "18fe2741-f5b2-488f-950b-2df1333afd71");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "6f8a8509-594a-43b8-830a-6e2be1fd742a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c280441-9dcf-4555-bce5-ee947e5ea043", true, "AQAAAAEAACcQAAAAEFaRhO7+90Ad8iueyrWwED3rxUDyh5Le3msyRzWoOE/dEYiOYmPzHPwfnVdXNDtprA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-110000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0def777f-7ac5-4f4a-97b9-a69a5a4a06fa", true, "AQAAAAEAACcQAAAAEKi/5VIDjba4T2tfhAFYnK4NzDt5v5N18tGzztyx4TLzvun6YleIBgi5DJNuVisRqA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-120000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54c3fcb8-84f6-4cc4-a499-c52702dd9457", true, "AQAAAAEAACcQAAAAEOXO6prUlMOjVBHynYMj2vQ9us7lprqlrtt/lReMLiSZPA0grMZTDBASzyqC3z7nPg==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-130000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22150c5e-1e58-40e1-8120-a2c2454a9fd3", true, "AQAAAAEAACcQAAAAEGI4LzTDdjknjqhLlBd3AYXxlmzEz/BgSAOcIM5C12GpHrE+ZkK6URTtQyrtW730Zw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-140000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3594c1b-1945-4117-b587-7f30bee5986b", true, "AQAAAAEAACcQAAAAEMEA/XA9MzhmYepRAfBpsjcIGnTsCU+m9aRRUHsOjvS+sJ69dqhWk46j0HDLXbpcbQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-150000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "669794f0-5914-4fb0-becf-fb3a8c98f38b", true, "AQAAAAEAACcQAAAAEBuxO71Mn/gcYEHNgWY9I1M1YTd18jy5ivgaWyxsWxskM9cP6+5u49ylEi/SkmRXrA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-160000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "755e6896-1bd5-4558-b228-a8caa1ea0b29", true, "AQAAAAEAACcQAAAAECW6TDB9oYMg50iiczGGGfzTivyY9MlF3QKb7Yfm7Ai2Edunm6eExcwOwOwBh4t25Q==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-170000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7c67bed-e19c-4bf0-b0ac-7c015e558c5f", true, "AQAAAAEAACcQAAAAEGw4uyu7gHbf7HO9H/5evMGe8Bmyfize0cmxN0Rb1pr7ICYqmD6GI1UXEscEvt6V7w==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-180000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42c4de64-2912-48c8-9b0b-2dc12711638e", true, "AQAAAAEAACcQAAAAEAMdbb5IYzngesV1v45cSwmgTyEgbV3AQV+OdqkshKMN/CLVBwIfktP5qwEgoV8QpQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-190000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8c72612-e0f1-4add-99ca-38acadae8289", true, "AQAAAAEAACcQAAAAEPr8lPFNudadBdceQ0YB4hqzfcvzPBuupvtLcXjR/7sDuBN/E3CNoEz3L1RPZX4vhg==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-200000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6aeddab-1e8f-4d0c-87d3-79a0dc9d44a0", true, "AQAAAAEAACcQAAAAEEzdF9uMugKRlHP26ieZBJRolG2Zebek6yXoc8DZf9VodaCPYiBL9vY6LTuPNDIfxw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-210000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c026278d-7497-436f-9f4e-f001b6730cbc", true, "AQAAAAEAACcQAAAAEFMhR/gBxi1SbZjtVtMwSpqwrCHY7bnSCsN/LUj+F9gzDhck/1Zek7IdQSb7+F3I0w==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-220000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "930ae991-8c8a-4a42-b3fc-057405913500", true, "AQAAAAEAACcQAAAAEDucq9VUjK/HHqsmfHsmuxEG30N/lAhHu/sooTDloWEUmz9Ly499GrI/1eXjOcgjfw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-230000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "491d54fb-c1eb-48c4-9062-faf17c6c1b2f", true, "AQAAAAEAACcQAAAAELfS5AUoDfsPwN3Ahd5oFQvtjNR/j5l9V6AfLxvHL2paE98qMbjCbxXBN5ap8eoQPQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-240000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f5ee2cf-f09a-44c7-9fdb-3be300958fee", true, "AQAAAAEAACcQAAAAEEj+CKp9+MzvP6C2o0klhfygVEft83Eop8dG23XF0U7a9Mw/n9hyXE/Mow5NhVTowQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-250000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2417a88a-0007-476c-bf38-72ce8ad6b60f", true, "AQAAAAEAACcQAAAAEGgCRmC7CXo1Wy4x2o7T9bTr51gBx3J2qSPmfFWRsMH3aHQdkdvs3HfC0dXtQTJ7RQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-260000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be09042d-c2df-40f6-bb3c-7ddd6155a40c", true, "AQAAAAEAACcQAAAAEPv17e9+7GFnxkeF0RPhQFR4tTtf6taS2Zfdbo0hW9Eu7oheGJI10hGftZ0AqGfQWQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-270000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52803ab8-0624-4444-bd92-dfba43dfd62e", true, "AQAAAAEAACcQAAAAEAccnLwMu3wZ9kQuW5HeYBd2MonOl3wzQ6hzGfvPe34xksv2eXaJAWFfWoSizL6f/g==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-300000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8b627e3-8c97-4a18-b254-cab715d253c3", true, "AQAAAAEAACcQAAAAEC37bXdG7Olw9f4lfMNsH/1EMS96XTz+ZLnwicoa8SnVbPlvBvU1UhVJqFmcAP+EDQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-400000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "010985f7-32b5-401d-afbc-d0661522ebbd", true, "AQAAAAEAACcQAAAAEK+jSVf4wGaj4rE0aW8zYkrEAiZ4xgbRhrbMYc33iSgessMaX8IGm13pCu8n4e1B+w==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-500000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56a3dca1-2bf4-44c1-8a18-7a2262a01f9d", true, "AQAAAAEAACcQAAAAEHb4RkY+ZLcbDWtEpqqSkJJRPvk1l/D77ry6otrxjaYAToIGOgQ8qXk0skH5WTlLMg==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-600000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85fecfaf-9e83-4b6a-aa76-969e5b2e86f4", true, "AQAAAAEAACcQAAAAEMJuWDlvaZJMtyEta5rf/5dn6hOEdGwgHwR/uVOYL0BGuxQ0fVLE6CIN0CsKhyl37A==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-700000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "432df35e-06a7-40ff-a9d2-ac4b00f27084", true, "AQAAAAEAACcQAAAAENSc7FMNOGnwabxG6U477g7z540lsPwzuBvoLen5HWkz2iHBm0q+m1cfakOJLBtW1w==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-800000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c9a6368-104a-4ebd-a8a3-0416ba4937dd", true, "AQAAAAEAACcQAAAAEL/AEV77Avgwp/TTwxVvOETClhi8T8PC4WAa9fYWp7xbzWatDFsCkM629s1DlI/D4w==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-900000000000"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7368182-026e-4c9c-8498-34418533c2fa", true, "AQAAAAEAACcQAAAAEAvzoh8A8zbRLWcJA4DPLwJ+Uz2NVnyswJ+lXVNWelh3HcOtn82aUVT96zC9NIe7HA==", null });
        }
    }
}
