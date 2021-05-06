using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class AddUserNameFixMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "ce60208d-218e-4d43-93f1-61b86da5fe96");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "1777de1f-65f3-40a0-a40f-96cb8eba127d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "a95b7e38-a9ba-4a01-9b0a-f7442d25decd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "590ff7cc-8e69-49df-bf54-ab63cf878978");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ea976eb-27cd-4fee-a815-6c2371a8f4f6", "AQAAAAEAACcQAAAAEDTaZ4sJIsEoNlWahezCQojPe6FlizQK2h4tN3BuNzqY1BWMt5JCY64oAotE2nQzLA==", "4a123418449a4c1cb067ff5a732c90ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-110000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2f2b7a1-77ed-49e3-b413-c3e4eb676c6d", "AQAAAAEAACcQAAAAENFOdWVkkBA2g6gQ4MzFHHJF1BaybXwikaf5Mtolef2qJi+sywoNfxzY0XVQygH6rg==", "ff17825e23924ae0b22f178aed981f67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-120000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4ce9e04-811e-49a8-b95a-8e5b73d306c2", "AQAAAAEAACcQAAAAEEMopFJkk83Zwg4IIbIHVE0nghQYcjH4RslDF1mWhm+7rEKdl+k5aFVCWJaWkfL8OA==", "d6e54c677ca24a6998f99ad41fcd6c74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-130000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e5a1d84-db06-4217-919f-50c9bcd1a906", "AQAAAAEAACcQAAAAEH/LS4fq1S5ytsVRk/c+ugQN2q8/dtZqdJerZIpR38WRHk3NQQdOKG/LgYcbTHYpzQ==", "7c2bb277fc464f4ba1308c300231827c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-140000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d68d931-6ba2-42dc-a05a-ee60afb47759", "AQAAAAEAACcQAAAAEArbC9SRT1LJJhLOL4OcYT1zbMUSe95TW/P/Zmoa63zOwlOauUZZspXLur+WXriRRA==", "8e8f0d39be424df88b261b2ce6f0d21b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-150000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0494adb-7d38-4612-93a6-27ff3ebf4862", "AQAAAAEAACcQAAAAEDWpubP7oP0tfxqyFIjVPIz518coT+hZQHggQSQu1foLrQUomraoG5uIA4bkZp/qUA==", "a97688517129443d843730230c92b91b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-160000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a516e3e1-6a72-4d29-8a06-606807c32b97", "AQAAAAEAACcQAAAAEEokksrexHcIWDxcuNKgFiShn0OqMZuLjNbmbWxwktK02oqzfL8NsCcRocsDnzr3Gg==", "8e523be53d004a48896ed5d4bc7a50f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-170000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29cb9d51-a094-480d-aa95-bcdf33aa2e2e", "AQAAAAEAACcQAAAAEAovE5igm3WYovnS20B5euXe+9B6RoSkP5gNoiIIme3bsl2tMUr590SB6dIBDxoWgg==", "93604a1298b04b42bdfcb48049e6fa3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-180000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7c8eeac-c0c1-4d1f-ba03-0647c50472ae", "AQAAAAEAACcQAAAAEDVxUIfFN27m7yuMzUel+cof4iYyBe5ZEOTsQHnfI7xyjwzB4RWtCmtdM6G86RMakA==", "a21f2e7333944b41a18cadb02dc2218b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-190000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fdac971-9b38-4078-bec7-d2ebd7fdf828", "AQAAAAEAACcQAAAAEHlc4kPC06nYTH8scsJUNvLzUX8edjVH7YpUypfIc+nGJLqI3KYOUQ4732+sVUnmlw==", "5af52b8bc72f45f3847a89e0885ab903" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-200000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fb622d1-0244-41c0-bfc4-0c8514fbff93", "AQAAAAEAACcQAAAAEGgLdPAeZOImjmI2nnEgV/a4V8pZRF4UCZoA+NaWgj33O34tNf5pKV0ygw/romSnlQ==", "1a92d47172274aa7b415e88fd5671fd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-210000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a363d7e-3b4e-4507-a2b3-cf2a632a2048", "AQAAAAEAACcQAAAAEDuLAhWI9kYXeB/8+T3DKHfnUcZWKkO1rdMm8jtElO/M4VqxoKllnWfla2+raCJ70w==", "419cb53744e54c408e8e7e03d18236e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-220000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c5e83f2-5a70-4be8-be48-98930f44dfbb", "AQAAAAEAACcQAAAAENnIzt0b5RfB8Nq8691+3YFaeYrrGhWMK9//uKwKKNjk15SIOzhlju4+taixSAvIww==", "7795b53a637a456e802d264ad11d4b49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-230000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4b65479-fe00-406b-8216-9263649c6074", "AQAAAAEAACcQAAAAECWg8la87UvycYuMT62qE1JiTM0SEd59a8dEzhcAsU0A7mXgq9D06OqHBU9zyJRnFg==", "8115b4033bab46939d1025977ed093b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-240000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c2c0f88-49a4-45b4-9f61-4b65dc6d6f21", "AQAAAAEAACcQAAAAEODFbIOWRNPLhi6CmRpYfKfBbMH1fllAjHZ6F8Bf+Mkjyd1qm9biut6qnxhW12eLFQ==", "8f6f39c5403644d7998777b4746de90e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-250000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "046d1b7a-1ef6-4350-8899-17a25ddd62e7", "AQAAAAEAACcQAAAAEIx+9gMPWz646wreAqceuRbRwKPunJKtpcIJC6md1kFw1IskomYxkjB1VTVN9eMDNQ==", "6010d85cb1ae43a2861f6f01a8ee7c80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-260000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e01bd55d-1eca-45b6-8406-767795bbbb63", "AQAAAAEAACcQAAAAEHaOzlSnHPxY8cynKurvXssjdxO9KlSFJ5wemwOpBRAS6i8fp0xrhNlElHLeTD7qaA==", "53f1910db053412194a7756e3ccd33f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-270000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "010f2624-1507-4b71-b4f3-a68fb09b4e31", "AQAAAAEAACcQAAAAEAuBfKr/RCPkcE8tLTPLjU9TZOo/Cj6Lc15zRl4MDTV7JE9uoZ8OzbE/1A5x0FElqg==", "95d89fdd4616415e85766f2900208424" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-280000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79b40697-d4f9-4419-bcb8-02b91104f108", "AQAAAAEAACcQAAAAEGa3qhZ/Sv4pD0Wy/4KBZbfCrcJPoXWyzl0OJs6uATO//wCca9MIfBS6FoiVIe3QFg==", "b3160ada8a9d421eaea3c71aee219a5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-290000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80fa8e80-6650-4512-99c5-06e0726d6a82", "AQAAAAEAACcQAAAAEJlPmTuprOyUBp2mFitqFsOV/K+ocyTrh4MYuoD0EJ7BbmzBJDkd/ZVggGgZXzxhqQ==", "845be8ff87b9428fa491728ac7fd47df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-300000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5594082f-2720-420e-88e6-acf663707c24", "AQAAAAEAACcQAAAAEJkEz+BFcw3J7fdCL7IzMVwoMYE9nzSxG5JadgnI5lWCEA2KzNF8vl62YJxdo9QLzg==", "393425542a2d49b0b5a4c9a95b4b23bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-310000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ff7b1d9e-5529-41c1-b397-ed5ec034da0c", "Joachim.Francois@BoardGameWebAPI.com", "Joachim Francois", "JOACHIM.FRANCOIS@BOARDGAMEWEBAPI.COM", "JOACHIM.FRANCOIS", "AQAAAAEAACcQAAAAECKvsl8uFpEUer4v6mrv6tZAeKX6DkLwIbnDCpd3OVyc93Hj019vlvWPv3SfQgsANg==", "49253d09a9fc4eaba8ca43438c6b3a1e", "Joachim.Francois" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-320000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ab09dab-b96d-4f1c-8f33-d7a7646bbb42", "AQAAAAEAACcQAAAAEAd4OCXbWDNp4WB2EfiC3NsNC5vUFYiN/lXaVSzeyQYlsQ4qVA59JmeBz1FcN9H7uA==", "9b51b0d7cdbf42da9b074f712c0a48e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-330000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5373f380-b1cf-4c35-b94d-43f69b3a4e32", "William.Schokkele@BoardGameWebAPI.com", "William Schokkele", "WILLIAM.SCHOKKELE@BOARDGAMEWEBAPI.COM", "WILLIAM.SCHOKKELE", "AQAAAAEAACcQAAAAEE9wcpCTpQqGjNI6NmIGvKudmKI6zHd18F8axi8PTMumkNgd35BtsOsrSj+/mP4IEQ==", "4e92da4c59b246f49d59a4586c1a378d", "William.Schokkele" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-340000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51261015-625e-434f-9a5b-75f8e629c2a7", "AQAAAAEAACcQAAAAEG0ROYkC+PBGi9OynMMInXx/YISyE42GAl+D2QX/NU468PsYK8OyfONjPIQWD0oeFg==", "c6ded2bc572c458e9ba78b8f67220d9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-400000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59916b3a-9e83-4056-9031-8a8e134035d3", "AQAAAAEAACcQAAAAEIu7Oy4XrWZczBB/k+SVyBxmjW1nZ78VXiRZb4rKEpb9cKoSjS/mwwsz9zR4GU1pBg==", "db545936a4f7498682e7b565c9a2a187" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-500000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad61789b-5506-4927-8b40-1e133c3a55ea", "AQAAAAEAACcQAAAAEJpJQpC/sd8XkdcWx4IjehDcyek3aXZBnhNRW+1bw5OrUlPHaTiXfeBy22wyz6uUKg==", "6546ffae995048e69744c82c14dfc754" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-600000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fa204fd-5db0-4f1a-8b9d-761406b6572b", "AQAAAAEAACcQAAAAEOK+6Dqi6Y4WrsKxQ3bUg6nPS5HFi9XjzpprGXP1ghF+f7NKnA6yo9O1kePBv3SCEg==", "d1263ac66c7440b1acc242eac43ae37d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-700000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00003103-fbeb-4216-8122-d05bfc7a4e5d", "AQAAAAEAACcQAAAAEFBi+10Uccibii11IcMCG6dwxacwYk0rF4Q0aYifNfyp2BM8t8skW5GjTh39dsIc6g==", "b868899da5b741d29008be1d547b5a4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-800000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e4eac4d-2a8f-4225-9581-c7e3f1cf5bdf", "AQAAAAEAACcQAAAAEPE17kLU7JrNQzeyxrLTRnnNXV2z8YHjSc4d8XYbrMlKgEaNb6DuCh2ZCX3jo7edoA==", "b7bd11405a6e484e9a4e3dc62f503211" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-900000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddbdf3b7-e8c5-4d6d-a8f5-e75378023634", "AQAAAAEAACcQAAAAEGS+aQ6LXqNCU7yZfLXZOuibVNO94cfZ89JI5pJPsmBXu8v+00erc7RE2/QBHRzk1Q==", "53d032cbbf92451d84b353fd5d6bdb59" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "2bb91deb-278d-461d-8cdf-affdef1e6581");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12481995-e017-41d7-a75a-7f2bdc3e5f46", "AQAAAAEAACcQAAAAEDEHglMxNvDEmwwiBE3jFEhYDQcRd9GgFl0EptwBu6BEG4KhI3zuQME47GySTale7w==", "35a7802042f042db95b5fe592e165ae2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-110000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae3d79f5-45cc-4ad5-86a5-75ea7640700e", "AQAAAAEAACcQAAAAEF6Jl6pIwLrgt6sIIvAchiNFX8kvfqlYZEZM4vkBf5omB1A4qi85AQc0Qd9/tYnXFA==", "c8def3cbe8644b598bea1e130bb43d00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-120000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdb82d7c-7cf4-4310-bad2-aebd70a68eef", "AQAAAAEAACcQAAAAELAZTMg6Jak6FGXK5AXpOq+OMS0RP0XZWcM3whhUBhO57CTHOGu+TXDNBZxAWrjQSw==", "f1a135bddb124c66b6939bf3b4f223ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-130000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed44ab0e-1984-45a9-a0df-91f9e3e03836", "AQAAAAEAACcQAAAAEIYKRRsqUjoUhVvHmSAajRPkNxtn6yNqqpdvHsE/mwDH+iVIdqulA4njpKQFHzFGUA==", "4d58859a07e644389d2c07dc54e5fab9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-140000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edacbbf4-d927-40ad-92b3-95edfd775c4d", "AQAAAAEAACcQAAAAECSqDOZuXIMQYtTuNzaUE3+BOiDSEBgMLhVGJP2qBowEJ1E2W9r3nhPSsxXJC+fUlg==", "4ee7a76106e24f12b6e603dd1502826f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-150000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ad115e6-38c4-454b-866a-c1caac130e87", "AQAAAAEAACcQAAAAEF/ptUAqA4me4VUwSZ0ZM8xjp5qweyjeKlPSTBIwDf1H7TSiikbUJ7cNhZvNRtQZyQ==", "12eb42a2bd724a76bde6b2d2d94b296a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-160000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc2ee91e-6ab9-4871-9026-a53411de2167", "AQAAAAEAACcQAAAAEDZEdo80/SxflUcmnoEvIuL5idjIUra+uAVyqQfm8a/PT27fEtV8F6anKLzv+59uiA==", "8ea567e7a93948338d30da59312d5e35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-170000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80f09e98-c9af-424e-b57b-3d77a80a048c", "AQAAAAEAACcQAAAAEChXvNeoiGv8UccNbOwJLAjw+QoRL29H906+HNkLUhAr/6UqTR4D+D8UreHYgcwQLg==", "5f8b05101b0c4981a31988e063803439" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-180000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57c31c67-3d31-4d9c-b6f6-69e7089403bf", "AQAAAAEAACcQAAAAEDM/w+NekpeiXI0SMWYyR3k7wNo1czy1RCI89d5HiR6oMSjbn/ibLcrP3J0ZS6wpKw==", "7627c510da6b4cdeb33001be1ebbe540" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-190000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4303c0b-7c4a-4abe-9ae4-31aa76d4f751", "AQAAAAEAACcQAAAAEF/I/8azgp676eEV8j745XFWh6LgYO0ZYiFaHW2gMHpzRCI+D/EIOihHQIp4QEhRew==", "fe0b939ed9d442a797a205c7f471f8b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-200000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29af580f-42db-4a56-a3d6-2d355e89004f", "AQAAAAEAACcQAAAAEHSqQc//TBr/nkAqQMpvz7q9cQnMj6T6LAGzid3QGS2ufw/TVDSrk2qWFn1KwHs8Qg==", "039d7a1f87344886a93dd0e8d1f18cde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-210000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0823a96-0786-49e4-b68e-9a0386625083", "AQAAAAEAACcQAAAAELzPz8ldmxgmfD6Tm/DGGPkLmpo3Ua5DXoOAAzkvX9gtH03Q6jTu/qZ0wFJWP3IGFQ==", "66975b792e2a431b90e28dea09f767fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-220000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c996916-6dc8-4082-b5bb-37fe6c315778", "AQAAAAEAACcQAAAAEGLqgDGYPKfHfnefuIDj5rh3fsfmvMM87mUe91+rNoM0wX+k+KIxD+WAxHpQW3AtJA==", "380ed233a6194c808489f569849550e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-230000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e2e2336-3bb5-4611-8541-33b18179343a", "AQAAAAEAACcQAAAAEDVnbYhsjXOMsy14mygMh+lhk8suxD+Sav0kGQ4nrMTvXdBm+urTXZjhhaYDC213qg==", "956374fae6d84276a0530b40e83012ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-240000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d004f08-41e8-4348-a7e8-2e13a15b9200", "AQAAAAEAACcQAAAAEIfiuUsMFbPT3+KpRAP91zGszCcZx1nBolbdXCYyfaw5kwnDrtB0SYwdkK9t21YWWQ==", "da2376fa041e481b97d7ff68944b6538" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-250000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dfa197a-2b43-45ba-878f-54f5a57ed220", "AQAAAAEAACcQAAAAEJ2DqjAhtGXcvpzdOgpC8QyX1h6Y0ZMXJJWLAF8zSfVBwEOrUg6WmZ3Lkou93rcZtQ==", "009cac5f56ac4baaabc93262f904f4c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-260000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1882cf7e-07a1-4ba3-a641-d690c6b60e26", "AQAAAAEAACcQAAAAEDwCkj8JPbb/lYhu2vzOajcwV12mVficQErZXw8F+H9CIX+c4ZgwzMRU/jiT5yXkCA==", "ce363563f2414f738ed56b1469cbcafc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-270000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "078f6fa1-75d1-4e3b-ac2d-ac7217b756ab", "AQAAAAEAACcQAAAAEFeqMW9woMRUNo8HTGg/UukjlByZcOd/31lIsEyaQq0tED7Q8/kuoyIMASFezZ8vaw==", "fd41faa18bf849ca92edb293e821ae5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-280000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ec29b48-fa06-4b72-9ef0-bd1f1e68a1a2", "AQAAAAEAACcQAAAAEKHJupQ/Q6R7hLDYtU3x2UDEkWKoqubQJK0DTW0ROWD0VHFg6hNFrBni533NzY8n7w==", "f076942faf8c4bd38c84f9b06123accc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-290000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "007a862a-a37f-45a4-aad3-6b5903de02e9", "AQAAAAEAACcQAAAAEKC6gE+vOe8or4iwvnXbtDMUPuZrbRkcgdSXV+8pJuuohelJkbH1Muui3bWrHXKS8w==", "1325f9bf55a4415e8c9ded35cc8d27b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-300000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1bbb786-b6ab-4e9d-8d2f-4a13f721212e", "AQAAAAEAACcQAAAAEPh4MTrRXnn+Q87AqBYZjXpjiQKD7VZZs4ZDctTunSqs7zM+9D0Ba74R0Fmtgejahw==", "ebb3c0e3f4b447d4aa4da3d3b032a791" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-310000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bff5dc47-81b0-495c-8507-2615b14d749d", "Joachim.François@BoardGameWebAPI.com", "Joachim François", "JOACHIM.FRANÇOIS@BOARDGAMEWEBAPI.COM", "JOACHIM.FRANÇOIS", "AQAAAAEAACcQAAAAEC2ZvVq8V+y2Io3xhr6FklCpx9SPF0tVnFIT1AtfQTv2V+CDYu4We+TZwHZPh6e9zg==", "deef5bb3b72445269f79446117b0ba93", "Joachim.François" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-320000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a338235b-1678-420e-a93e-009505ef74b2", "AQAAAAEAACcQAAAAENjULu9WtRsxa971f1iBUSScZ2oyGS0BDFXUjw+7tiAFuRM34oHPgwVVsK5u5kOsdw==", "4aae7559637d42c1ab651d2f7a372e69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-330000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cbd0dd7c-6cb2-439f-b979-4a50c3d14073", "William.Scholkkelé@BoardGameWebAPI.com", "William Scholkkelé", "WILLIAM.SCHOLKKELÉ@BOARDGAMEWEBAPI.COM", "WILLIAM.SCHOLKKELÉ", "AQAAAAEAACcQAAAAEPRzMZp2OzoEpbdZI9G9/CsuFUeQg+dLwMt1gyR3XsFvdS6qljqjes7K1CAT2SKgeA==", "e589ebc190814328a538d179bff0f364", "William.Scholkkelé" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-340000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d75b421-04e2-4164-99b0-db76bb30eeb2", "AQAAAAEAACcQAAAAELCK9odEtuhlwZ+2GTeAOyKW2aj/oMVetcVSpxR2/6psug2F/n9k/8uKwAQdSj7gvw==", "7d0a79888dcd4266beff2ef2d12dcc86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-400000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8a6a3b3-cd99-4abb-8b75-acb930ad4706", "AQAAAAEAACcQAAAAEPg4b3Mimz4yFi1Q06RpSUxLO3dnr2X9uPEHLmwTIXNQxvCfINvUGxI229X3WbclDw==", "742422feb85245339714fa0058f40e4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-500000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e0f5a44-a25d-45ec-beab-4056ddf65289", "AQAAAAEAACcQAAAAEC77/tdr8KmwWBhH2h06WBX3x7Dpz7wKBEzoh/QQDXw8vR9nCTqGrgXfNJNUfiRjGA==", "485a07a35aa74b46924f47b76654dc31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-600000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5fbb40e-2634-497a-902a-3c6d045c7c03", "AQAAAAEAACcQAAAAEMGTq+8zGg8vFxpEiuHjjzKHSgcDBpe2GtCuiRrCeKQSTmCj76DGtumoaIVmlIRFqQ==", "f71ae99d851845b6aff0aa92886be5ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-700000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d64a8eee-f601-42c5-aea2-4f7dde9e9bc6", "AQAAAAEAACcQAAAAEExZgNAAfxgJTC464yCot+9hGmO2xK8mea1BdHQ3u0BbBhba+hbNaMCgizeEFkEbpQ==", "fc60297ee2314452ae53ef0e291b2d5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-800000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e37cdbde-b305-46d1-b35a-d41b9517dc14", "AQAAAAEAACcQAAAAEDmIY2cek0Widsb2xX+uZdvbtk6UIvWmVCuP5lNVsWkS/Ezsjqkvyhadd+T4Qfagvw==", "cda4246dda924092b8403101b918768b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-900000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "791bf704-af4d-4fad-af78-78b01613a5c6", "AQAAAAEAACcQAAAAEOwel71VtdXmbzJot7hiP+67AE7P16EyAOGYnukZ/gzp+O5nliVVRuiuBjqDIlacXg==", "fabec9876f7745d1a071a9bd6578e691" });
        }
    }
}
