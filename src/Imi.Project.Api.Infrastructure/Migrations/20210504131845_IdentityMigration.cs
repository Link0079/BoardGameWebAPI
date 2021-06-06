using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class IdentityMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamesScores_Players_PlayerId",
                table: "GamesScores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.RenameTable(
                name: "Players",
                newName: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("00000001-0000-0000-0000-000000000000"), "47b74fd4-d691-46ba-8638-6af806a7bea5", "Admin", "ADMIN" },
                    { new Guid("00000002-0000-0000-0000-000000000000"), "18fe2741-f5b2-488f-950b-2df1333afd71", "Player", "PLAYER" },
                    { new Guid("00000003-0000-0000-0000-000000000000"), "6f8a8509-594a-43b8-830a-6e2be1fd742a", "BoardGameEditor", "BOARDGAMEEDITOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "9c280441-9dcf-4555-bce5-ee947e5ea043", "Bjorn.Vossen@BoardGameWebAPI.com", true, "BJORN.VOSSEN@BOARDGAMEWEBAPI.COM", "BJORN.VOSSEN", "AQAAAAEAACcQAAAAEFaRhO7+90Ad8iueyrWwED3rxUDyh5Le3msyRzWoOE/dEYiOYmPzHPwfnVdXNDtprA==", "Bjorn.Vossen" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-110000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "0def777f-7ac5-4f4a-97b9-a69a5a4a06fa", "Melissa.Rauch@BoardGameWebAPI.com", true, "MELISSA.RAUCH@BOARDGAMEWEBAPI.COM", "MELISSA.RAUCH", "AQAAAAEAACcQAAAAEKi/5VIDjba4T2tfhAFYnK4NzDt5v5N18tGzztyx4TLzvun6YleIBgi5DJNuVisRqA==", "Melissa.Rauch" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-120000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "54c3fcb8-84f6-4cc4-a499-c52702dd9457", "Mayim.Bialik@BoardGameWebAPI.com", true, "MAYIM.BIALIK@BOARDGAMEWEBAPI.COM", "MAYIM.BIALIK", "AQAAAAEAACcQAAAAEOXO6prUlMOjVBHynYMj2vQ9us7lprqlrtt/lReMLiSZPA0grMZTDBASzyqC3z7nPg==", "Mayim.Bialik" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-130000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "22150c5e-1e58-40e1-8120-a2c2454a9fd3", "Gabriel.Macht@BoardGameWebAPI.com", true, "GABRIEL.MACHT@BOARDGAMEWEBAPI.COM", "GABRIEL.MACHT", "AQAAAAEAACcQAAAAEGI4LzTDdjknjqhLlBd3AYXxlmzEz/BgSAOcIM5C12GpHrE+ZkK6URTtQyrtW730Zw==", "Gabriel.Macht" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-140000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "f3594c1b-1945-4117-b587-7f30bee5986b", "Megan.Markle@BoardGameWebAPI.com", true, "MEGAN.MARKLE@BOARDGAMEWEBAPI.COM", "MEGAN.MARKLE", "AQAAAAEAACcQAAAAEMEA/XA9MzhmYepRAfBpsjcIGnTsCU+m9aRRUHsOjvS+sJ69dqhWk46j0HDLXbpcbQ==", "Megan.Markle" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-150000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "669794f0-5914-4fb0-becf-fb3a8c98f38b", "Patrick.J..Adams@BoardGameWebAPI.com", true, "PATRICK.J..ADAMS@BOARDGAMEWEBAPI.COM", "PATRICK.J..ADAMS", "AQAAAAEAACcQAAAAEBuxO71Mn/gcYEHNgWY9I1M1YTd18jy5ivgaWyxsWxskM9cP6+5u49ylEi/SkmRXrA==", "Patrick.J..Adams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-160000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "755e6896-1bd5-4558-b228-a8caa1ea0b29", "Sarah.Rafferty@BoardGameWebAPI.com", true, "SARAH.RAFFERTY@BOARDGAMEWEBAPI.COM", "SARAH.RAFFERTY", "AQAAAAEAACcQAAAAECW6TDB9oYMg50iiczGGGfzTivyY9MlF3QKb7Yfm7Ai2Edunm6eExcwOwOwBh4t25Q==", "Sarah.Rafferty" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-170000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "b7c67bed-e19c-4bf0-b0ac-7c015e558c5f", "Rick.Hoffman@BoardGameWebAPI.com", true, "RICK.HOFFMAN@BOARDGAMEWEBAPI.COM", "RICK.HOFFMAN", "AQAAAAEAACcQAAAAEGw4uyu7gHbf7HO9H/5evMGe8Bmyfize0cmxN0Rb1pr7ICYqmD6GI1UXEscEvt6V7w==", "Rick.Hoffman" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-180000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "42c4de64-2912-48c8-9b0b-2dc12711638e", "Eric.Roberts@BoardGameWebAPI.com", true, "ERIC.ROBERTS@BOARDGAMEWEBAPI.COM", "ERIC.ROBERTS", "AQAAAAEAACcQAAAAEAMdbb5IYzngesV1v45cSwmgTyEgbV3AQV+OdqkshKMN/CLVBwIfktP5qwEgoV8QpQ==", "Eric.Roberts" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-190000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "b8c72612-e0f1-4add-99ca-38acadae8289", "Margot.Robbie@BoardGameWebAPI.com", true, "MARGOT.ROBBIE@BOARDGAMEWEBAPI.COM", "MARGOT.ROBBIE", "AQAAAAEAACcQAAAAEPr8lPFNudadBdceQ0YB4hqzfcvzPBuupvtLcXjR/7sDuBN/E3CNoEz3L1RPZX4vhg==", "Margot.Robbie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-200000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "a6aeddab-1e8f-4d0c-87d3-79a0dc9d44a0", "Sofie.Brauwers@BoardGameWebAPI.com", true, "SOFIE.BRAUWERS@BOARDGAMEWEBAPI.COM", "SOFIE.BRAUWERS", "AQAAAAEAACcQAAAAEEzdF9uMugKRlHP26ieZBJRolG2Zebek6yXoc8DZf9VodaCPYiBL9vY6LTuPNDIfxw==", "Sofie.Brauwers" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-210000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "c026278d-7497-436f-9f4e-f001b6730cbc", "Erin.Richards@BoardGameWebAPI.com", true, "ERIN.RICHARDS@BOARDGAMEWEBAPI.COM", "ERIN.RICHARDS", "AQAAAAEAACcQAAAAEFMhR/gBxi1SbZjtVtMwSpqwrCHY7bnSCsN/LUj+F9gzDhck/1Zek7IdQSb7+F3I0w==", "Erin.Richards" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-220000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "930ae991-8c8a-4a42-b3fc-057405913500", "Morena.Baccarin@BoardGameWebAPI.com", true, "MORENA.BACCARIN@BOARDGAMEWEBAPI.COM", "MORENA.BACCARIN", "AQAAAAEAACcQAAAAEDucq9VUjK/HHqsmfHsmuxEG30N/lAhHu/sooTDloWEUmz9Ly499GrI/1eXjOcgjfw==", "Morena.Baccarin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-230000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "491d54fb-c1eb-48c4-9062-faf17c6c1b2f", "Jessica.Lucas@BoardGameWebAPI.com", true, "JESSICA.LUCAS@BOARDGAMEWEBAPI.COM", "JESSICA.LUCAS", "AQAAAAEAACcQAAAAELfS5AUoDfsPwN3Ahd5oFQvtjNR/j5l9V6AfLxvHL2paE98qMbjCbxXBN5ap8eoQPQ==", "Jessica.Lucas" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-240000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "9f5ee2cf-f09a-44c7-9fdb-3be300958fee", "Jamie.Chung@BoardGameWebAPI.com", true, "JAMIE.CHUNG@BOARDGAMEWEBAPI.COM", "JAMIE.CHUNG", "AQAAAAEAACcQAAAAEEj+CKp9+MzvP6C2o0klhfygVEft83Eop8dG23XF0U7a9Mw/n9hyXE/Mow5NhVTowQ==", "Jamie.Chung" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-250000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "2417a88a-0007-476c-bf38-72ce8ad6b60f", "Natalie.Alyn.Lind@BoardGameWebAPI.com", true, "NATALIE.ALYN.LIND@BOARDGAMEWEBAPI.COM", "NATALIE.ALYN.LIND", "AQAAAAEAACcQAAAAEGgCRmC7CXo1Wy4x2o7T9bTr51gBx3J2qSPmfFWRsMH3aHQdkdvs3HfC0dXtQTJ7RQ==", "Natalie.Alyn.Lind" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-260000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "be09042d-c2df-40f6-bb3c-7ddd6155a40c", "Amber.Heard@BoardGameWebAPI.com", true, "AMBER.HEARD@BOARDGAMEWEBAPI.COM", "AMBER.HEARD", "AQAAAAEAACcQAAAAEPv17e9+7GFnxkeF0RPhQFR4tTtf6taS2Zfdbo0hW9Eu7oheGJI10hGftZ0AqGfQWQ==", "Amber.Heard" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-270000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "52803ab8-0624-4444-bd92-dfba43dfd62e", "Megan.Fox@BoardGameWebAPI.com", true, "MEGAN.FOX@BOARDGAMEWEBAPI.COM", "MEGAN.FOX", "AQAAAAEAACcQAAAAEAccnLwMu3wZ9kQuW5HeYBd2MonOl3wzQ6hzGfvPe34xksv2eXaJAWFfWoSizL6f/g==", "Megan.Fox" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-300000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "d8b627e3-8c97-4a18-b254-cab715d253c3", "Athena.Faris@BoardGameWebAPI.com", true, "ATHENA.FARIS@BOARDGAMEWEBAPI.COM", "ATHENA.FARIS", "AQAAAAEAACcQAAAAEC37bXdG7Olw9f4lfMNsH/1EMS96XTz+ZLnwicoa8SnVbPlvBvU1UhVJqFmcAP+EDQ==", "Athena.Faris" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-400000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "010985f7-32b5-401d-afbc-d0661522ebbd", "Abigail.Spencer@BoardGameWebAPI.com", true, "ABIGAIL.SPENCER@BOARDGAMEWEBAPI.COM", "ABIGAIL.SPENCER", "AQAAAAEAACcQAAAAEK+jSVf4wGaj4rE0aW8zYkrEAiZ4xgbRhrbMYc33iSgessMaX8IGm13pCu8n4e1B+w==", "Abigail.Spencer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-500000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "56a3dca1-2bf4-44c1-8a18-7a2262a01f9d", "Kaley.Cuoco@BoardGameWebAPI.com", true, "KALEY.CUOCO@BOARDGAMEWEBAPI.COM", "KALEY.CUOCO", "AQAAAAEAACcQAAAAEHb4RkY+ZLcbDWtEpqqSkJJRPvk1l/D77ry6otrxjaYAToIGOgQ8qXk0skH5WTlLMg==", "Kaley.Cuoco" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-600000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "85fecfaf-9e83-4b6a-aa76-969e5b2e86f4", "Jim.Parsons@BoardGameWebAPI.com", true, "JIM.PARSONS@BOARDGAMEWEBAPI.COM", "JIM.PARSONS", "AQAAAAEAACcQAAAAEMJuWDlvaZJMtyEta5rf/5dn6hOEdGwgHwR/uVOYL0BGuxQ0fVLE6CIN0CsKhyl37A==", "Jim.Parsons" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-700000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "432df35e-06a7-40ff-a9d2-ac4b00f27084", "Johnny.Galecki@BoardGameWebAPI.com", true, "JOHNNY.GALECKI@BOARDGAMEWEBAPI.COM", "JOHNNY.GALECKI", "AQAAAAEAACcQAAAAENSc7FMNOGnwabxG6U477g7z540lsPwzuBvoLen5HWkz2iHBm0q+m1cfakOJLBtW1w==", "Johnny.Galecki" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-800000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "3c9a6368-104a-4ebd-a8a3-0416ba4937dd", "Kunal.Nayyar@BoardGameWebAPI.com", true, "KUNAL.NAYYAR@BOARDGAMEWEBAPI.COM", "KUNAL.NAYYAR", "AQAAAAEAACcQAAAAEL/AEV77Avgwp/TTwxVvOETClhi8T8PC4WAa9fYWp7xbzWatDFsCkM629s1DlI/D4w==", "Kunal.Nayyar" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-900000000000"),
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "e7368182-026e-4c9c-8498-34418533c2fa", "Simon.Helberg@BoardGameWebAPI.com", true, "SIMON.HELBERG@BOARDGAMEWEBAPI.COM", "SIMON.HELBERG", "AQAAAAEAACcQAAAAEAvzoh8A8zbRLWcJA4DPLwJ+Uz2NVnyswJ+lXVNWelh3HcOtn82aUVT96zC9NIe7HA==", "Simon.Helberg" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-100000000000"), new Guid("00000001-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-500000000000"), new Guid("00000003-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-400000000000"), new Guid("00000003-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-300000000000"), new Guid("00000003-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-270000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-260000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-250000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-240000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-230000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-220000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-210000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-600000000000"), new Guid("00000003-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-190000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-170000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-160000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-150000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-140000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-130000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-120000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-110000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-900000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-800000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-200000000000"), new Guid("00000001-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-180000000000"), new Guid("00000002-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-700000000000"), new Guid("00000003-0000-0000-0000-000000000000") }
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_GamesScores_AspNetUsers_PlayerId",
                table: "GamesScores",
                column: "PlayerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamesScores_AspNetUsers_PlayerId",
                table: "GamesScores");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "Players");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GamesScores_Players_PlayerId",
                table: "GamesScores",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");
        }
    }
}
