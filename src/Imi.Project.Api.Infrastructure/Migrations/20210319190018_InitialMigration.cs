using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Dob = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoardGames",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Year = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Age = table.Column<int>(nullable: true),
                    Rating = table.Column<int>(nullable: true),
                    PlayTime = table.Column<int>(nullable: true),
                    MinPlayers = table.Column<int>(nullable: true),
                    MaxPlayers = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Stock = table.Column<bool>(nullable: false),
                    PhotoUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardGames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoardGameArtists",
                columns: table => new
                {
                    BoardGameId = table.Column<Guid>(nullable: false),
                    ArtistId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardGameArtists", x => new { x.BoardGameId, x.ArtistId });
                    table.ForeignKey(
                        name: "FK_BoardGameArtists_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BoardGameArtists_BoardGames_BoardGameId",
                        column: x => x.BoardGameId,
                        principalTable: "BoardGames",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlayedGames",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BoardGameId = table.Column<Guid>(nullable: false),
                    PlayTime = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayedGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayedGames_BoardGames_BoardGameId",
                        column: x => x.BoardGameId,
                        principalTable: "BoardGames",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BoardGameCategories",
                columns: table => new
                {
                    BoardGameId = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardGameCategories", x => new { x.BoardGameId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_BoardGameCategories_BoardGames_BoardGameId",
                        column: x => x.BoardGameId,
                        principalTable: "BoardGames",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BoardGameCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GamesScores",
                columns: table => new
                {
                    PlayerId = table.Column<Guid>(nullable: false),
                    PlayedGameId = table.Column<Guid>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamesScores", x => new { x.PlayedGameId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_GamesScores_PlayedGames_PlayedGameId",
                        column: x => x.PlayedGameId,
                        principalTable: "PlayedGames",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GamesScores_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoardGameArtists_ArtistId",
                table: "BoardGameArtists",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_BoardGameCategories_CategoryId",
                table: "BoardGameCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GamesScores_PlayerId",
                table: "GamesScores",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayedGames_BoardGameId",
                table: "PlayedGames",
                column: "BoardGameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoardGameArtists");

            migrationBuilder.DropTable(
                name: "BoardGameCategories");

            migrationBuilder.DropTable(
                name: "GamesScores");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "PlayedGames");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "BoardGames");
        }
    }
}
