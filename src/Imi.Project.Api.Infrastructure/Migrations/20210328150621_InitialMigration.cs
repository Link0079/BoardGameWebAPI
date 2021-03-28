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
                    Dob = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
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
                    PlayTime = table.Column<int>(nullable: false),
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
                    Dob = table.Column<DateTime>(nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamesScores_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Dob", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0001-0000-0000-000000000000"), new DateTime(1958, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ludovic Roudy" },
                    { new Guid("00000000-0028-0000-0000-000000000000"), new DateTime(1970, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Chris Quilliams" },
                    { new Guid("00000000-0029-0000-0000-000000000000"), new DateTime(1979, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Josh J. Carlson" },
                    { new Guid("00000000-0030-0000-0000-000000000000"), new DateTime(1960, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Anthony LeTourneau" },
                    { new Guid("00000000-0031-0000-0000-000000000000"), new DateTime(1968, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Martin Hoffmann" },
                    { new Guid("00000000-0032-0000-0000-000000000000"), new DateTime(1953, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Claus Stephan" },
                    { new Guid("00000000-0033-0000-0000-000000000000"), new DateTime(1988, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Mirko Suzuki" },
                    { new Guid("00000000-0034-0000-0000-000000000000"), new DateTime(1959, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Dennis Lohausen" },
                    { new Guid("00000000-0035-0000-0000-000000000000"), new DateTime(1980, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "John Howe" },
                    { new Guid("00000000-0036-0000-0000-000000000000"), new DateTime(1955, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Fabio Maiorana" },
                    { new Guid("00000000-0037-0000-0000-000000000000"), new DateTime(1976, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Jason Behnke" },
                    { new Guid("00000000-0027-0000-0000-000000000000"), new DateTime(1981, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Sabrina Miramon" },
                    { new Guid("00000000-0039-0000-0000-000000000000"), new DateTime(1990, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Loic Billiau" },
                    { new Guid("00000000-0041-0000-0000-000000000000"), new DateTime(1975, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tomas Kucerovsky" },
                    { new Guid("00000000-0042-0000-0000-000000000000"), new DateTime(1992, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Filip Murmak" },
                    { new Guid("00000000-0043-0000-0000-000000000000"), new DateTime(1958, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Nan Rangsima" },
                    { new Guid("00000000-0044-0000-0000-000000000000"), new DateTime(1962, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Fabien Fulchiron" },
                    { new Guid("00000000-0045-0000-0000-000000000000"), new DateTime(1972, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Manuel Sanchez" },
                    { new Guid("00000000-0046-0000-0000-000000000000"), new DateTime(1982, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Klemens Franz" },
                    { new Guid("00000000-0047-0000-0000-000000000000"), new DateTime(1992, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Alexander Pfister" },
                    { new Guid("00000000-0048-0000-0000-000000000000"), new DateTime(1955, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Andreas Resch" },
                    { new Guid("00000000-0049-0000-0000-000000000000"), new DateTime(1965, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Michal Oracz" },
                    { new Guid("00000000-0050-0000-0000-000000000000"), new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ewa Labak" },
                    { new Guid("00000000-0040-0000-0000-000000000000"), new DateTime(1957, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Stephane Gatiez" },
                    { new Guid("00000000-0026-0000-0000-000000000000"), new DateTime(1961, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Sebastian Koziner" },
                    { new Guid("00000000-0038-0000-0000-000000000000"), new DateTime(1969, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Loic Berger" },
                    { new Guid("00000000-0024-0000-0000-000000000000"), new DateTime(1982, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Chris Raimo" },
                    { new Guid("00000000-0025-0000-0000-000000000000"), new DateTime(1985, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "J. Lonnee" },
                    { new Guid("00000000-0002-0000-0000-000000000000"), new DateTime(1963, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Alexandr Elichev" },
                    { new Guid("00000000-0003-0000-0000-000000000000"), new DateTime(1979, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Alvaro Nebot" },
                    { new Guid("00000000-0004-0000-0000-000000000000"), new DateTime(1989, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Josh T. McDowell" },
                    { new Guid("00000000-0005-0000-0000-000000000000"), new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Isaac Fryxelius" },
                    { new Guid("00000000-0006-0000-0000-000000000000"), new DateTime(1966, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kyle Ferrin" },
                    { new Guid("00000000-0007-0000-0000-000000000000"), new DateTime(1956, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Clay Brooks" },
                    { new Guid("00000000-0009-0000-0000-000000000000"), new DateTime(1969, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Nate Storm" },
                    { new Guid("00000000-0010-0000-0000-000000000000"), new DateTime(1987, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ryan Laukat" },
                    { new Guid("00000000-0011-0000-0000-000000000000"), new DateTime(1994, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Christopher Hosch" },
                    { new Guid("00000000-0012-0000-0000-000000000000"), new DateTime(1964, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Marcin Jakubowski" },
                    { new Guid("00000000-0008-0000-0000-000000000000"), new DateTime(1951, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Raul Ramous" },
                    { new Guid("00000000-0022-0000-0000-000000000000"), new DateTime(1997, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Anders Finer" },
                    { new Guid("00000000-0014-0000-0000-000000000000"), new DateTime(1985, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ana Maria Martinez Jaramillo" },
                    { new Guid("00000000-0015-0000-0000-000000000000"), new DateTime(1992, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Natalia Rojas" },
                    { new Guid("00000000-0016-0000-0000-000000000000"), new DateTime(1999, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Beth Sobel" },
                    { new Guid("00000000-0017-0000-0000-000000000000"), new DateTime(1950, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Andrew Bosley" },
                    { new Guid("00000000-0018-0000-0000-000000000000"), new DateTime(1963, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cody Jones" },
                    { new Guid("00000000-0019-0000-0000-000000000000"), new DateTime(1972, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Dann May" },
                    { new Guid("00000000-0020-0000-0000-000000000000"), new DateTime(1983, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cristi Balancescu" },
                    { new Guid("00000000-0021-0000-0000-000000000000"), new DateTime(1996, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Yoann Boissonnet" },
                    { new Guid("00000000-0013-0000-0000-000000000000"), new DateTime(1977, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ignacio Bazan Lazcano" },
                    { new Guid("00000000-0023-0000-0000-000000000000"), new DateTime(1989, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Milan Vavron" }
                });

            migrationBuilder.InsertData(
                table: "BoardGames",
                columns: new[] { "Id", "Age", "Description", "IsDeleted", "MaxPlayers", "MinPlayers", "PhotoUrl", "PlayTime", "Price", "Rating", "Stock", "Title", "Year" },
                values: new object[,]
                {
                    { new Guid("00000027-0000-0000-0000-000000000000"), 12, "Xia: Legends of a Drift System is a 3-5 player sandbox style competitive space adventure. Each player starts as a lowly but hopeful captain of a small starship. Players fly their ships about the system, completing a variety of missions, exploring new sectors and battling other ships. Navigating hazardous environments, players choose to mine, salvage, or trade valuable cargo. Captains vie with each other for Titles, riches, and most importantly Fame. The most adaptive, risk taking, and creative players will excel. One captain will rise above the others, surpassing mortality by becoming Legend!", false, 5, 3, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 180, 99m, 7, true, "Xia: Legends of a Drift System", 2014 },
                    { new Guid("00000026-0000-0000-0000-000000000000"), 14, "Heroes of Land, Air & Sea is a 4X-style board game with miniatures that tells the epic tale of orcs vs. humans, dwarves vs. elves, battling kingdoms, and the individuals who turn the tides of war. Players control one of these classic factions, competing to expand their kingdom into new territory. Even the greatest kingdoms begin as small townships, therefore players begin with only a basic town hall, a couple of peons, and a single warrior. From there, players must explore the territory around them, build up their work force, fortify their army, and develop their kingdom — all through careful action selection, exploitation, war, and resource management. As players reach milestones in the development of their kingdom, they gain access to many advantages. Peons become warriors, warriors become powerful heroes, and town halls eventually become castles. Players gain access to water, and even air, vessels and creatures. Boarding these vessels and creatures with your units allows for faster travel across the vast game board and for positioning armies for powerful attacks.", false, 6, 3, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 480, 120m, 8, true, "Heroes of Land, Air and Sea", 2017 },
                    { new Guid("00000025-0000-0000-0000-000000000000"), 13, "In War of the Ring, one player takes control of the Free Peoples (FP), the other player controls Shadow Armies (SA). Initially, the Free People Nations are reluctant to take arms against Sauron, so they must be attacked by Sauron or persuaded by Gandalf or other Companions, before they start to fight properly: this is represented by the Political Track, which shows if a Nation is ready to fight in the War of the Ring or not.The game can be won by a military victory, if Sauron conquers a certain number of Free People cities and strongholds or vice versa. But the true hope of the Free Peoples lies with the quest of the Ringbearer: while the armies clash across Middle Earth, the Fellowship of the Ring is trying to get secretly to Mount Doom to destroy the One Ring. Sauron is not aware of the real intention of his enemies but is looking across Middle Earth for the precious Ring, so that the Fellowship is going to face numerous dangers, represented by the rules of The Hunt for the Ring. But the Companions can spur the Free Peoples to the fight against Sauron, so the Free People player must balance the need to protect the Ringbearer from harm, against the attempt to raise a proper defense against the armies of the Shadow, so that they do not overrun Middle Earth before the Ringbearer completes his quest. Each game turn revolves around the roll of Action Dice: each die corresponds to an action that a player can do during a turn. Depending on the face rolled on each die, different actions are possible (moving armies, characters, recruiting troops, advancing a Political Track).", false, 4, 2, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 180, 70m, 8, true, "War of the Rings", 2012 },
                    { new Guid("00000024-0000-0000-0000-000000000000"), 13, "Merchants & Marauders lets you live the life of an influential merchant or a dreaded pirate in the Caribbean during the Golden Age of Piracy. Seek your fortune through trade, rumor hunting, missions, and of course, plundering. Modify your ship, buy impressive vessels, load deadly special ammunition, and hire specialist crew members. Will your captain gain eternal glory and immense wealth - or find his wet grave under the stormy surface of the Caribbean Sea? In Merchants and Marauders, players take on the role of a captain of a small vessel in the Caribbean. The goal is to be the first to achieve 10 \"glory\" points through performing daring deeds (through the completion of missions or rumors), crushing your enemies (through defeating opponents and NPCs in combat), amassing gold, performing an epic plunder or pulling off the trade of a lifetime, and buying a grand ship. While some points earned from performing various tasks are permanent, players earn points for amassing gold, which can be stolen or lost (or at least diminished) if their captain is killed. Points due to gold are hidden so there's some uncertainty about when the game will end. ", false, 4, 2, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 180, 56m, 7, true, "Merchants and Marauders", 2012 },
                    { new Guid("00000019-0000-0000-0000-000000000000"), 14, "Rome & Roll is a heavy roll-and-write board game by Dávid Turczi and Nick Shaw in which 1-4 players compete to craft an empire. Draft from a pool of custom dice to collect resources, construct the town, and organize armies. Political alliances, the colonies, and even the Gods all have a part to play. Imperii Gloria!", false, 4, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 90, 12m, 7, false, "Rome and Roll", 2020 },
                    { new Guid("00000022-0000-0000-0000-000000000000"), 10, "Imperial Settlers: Roll And Write is a standalone game set in the universe of Imperial Settlers and Imperial Settlers: Empires of the North. The game is heavily focused on engine building! Constructing buildings grants you a special bonus, and with each passing turn the game offers you more choices as your empire gains momentum. Imperial Settlers: Roll & Write has two game modes. The standard mode is a 2-4 player competitive challenge in which you try to gain more points than your opponents. The adventure mode for a single player offers 48 unique game sheets. Each sheet presents unique challenges and gameplay as players have different buildings at the start. Tweak your engine and get as many points as you can! Grab your pencil, roll your dice, and create the most prosperous empire!", false, 4, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 30, 20m, 6, false, "Imperial Settlers: Roll and Write", 2019 },
                    { new Guid("00000021-0000-0000-0000-000000000000"), 10, "Queen Gimnax has ordered the reclamation of the northern lands. As a cartographer in her service, you are sent to map this territory, claiming it for the Kingdom of Nalos. Through official edicts, the queen announces which lands she prizes most, and you will increase your reputation by meeting her demands. But you are not alone in this wilderness. The Dragul contest your claims with their outposts, so you must draw your lines carefully to reduce their influence. Reclaim the greatest share of the queen’s desired lands and you will be declared the greatest cartographer in the kingdom. In Cartographers: A Roll Player Tale, players compete to earn the most reputation stars by the time four seasons have passed. Each season, players draw on their map sheets and earn reputation by carrying out the queen's edicts before the season is over. The player with the most reputation stars at the end of winter wins!", false, 99, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 45, 18m, 7, false, "Cartographers", 2019 },
                    { new Guid("00000020-0000-0000-0000-000000000000"), 8, "In the multiplayer puzzle game Railroad Ink, your goal is to connect as many exits on your board as possible. Each round, a set of dice are rolled in the middle of the table, determining which kind of road and railway routes are available to all players. You have to draw these routes on your erasable boards to create transport lines and connect your exits, trying to optimize the available symbols better than your opponents. The more exits you connect, the more points you score at the end of the game, but you lose points for each incomplete route, so plan carefully! Will you press your luck and try to stretch your transportation network to the next exit, or will you play it safe and start a new, simpler to manage route? Railroad Ink comes in two versions, each one including two expansions with additional dice sets that add special rules to your games. The Blazing Red Edition includes the Lava and Meteor expansions. Try to confine the lava coming from the erupting volcano before it destroys your routes, or deal with the havoc brought by the meteor strikes and mine the craters for precious ore. These special rules can spice up things and make each game play and feel different.", false, 6, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 30, 20m, 7, true, "Railroad Ink", 2018 },
                    { new Guid("00000028-0000-0000-0000-000000000000"), 12, "In the 2400s, mankind begins to terraform the planet Mars. Giant corporations, sponsored by the World Government on Earth, initiate huge projects to raise the temperature, the oxygen level, and the ocean coverage until the environment is habitable. In Terraforming Mars, you play one of those corporations and work together in the terraforming process, but compete for getting victory points that are awarded not only for your contribution to the terraforming, but also for advancing human infrastructure throughout the solar system, and doing other commendable things. The players acquire unique project cards(from over two hundred different ones) by buying them to their hand. The projects(cards) can represent anything from introducing plant life or animals, hurling asteroids at the surface, building cities, to mining the moons of Jupiter and establishing greenhouse gas industries to heat up the atmosphere.The cards can give you immediate bonuses, as well as increasing your production of different resources.Many cards also have requirements and they become playable when the temperature, oxygen, or ocean coverage increases enough. Buying cards is costly, so there is a balance between buying cards(3 megacredits per card) and actually playing them(which can cost anything between 0 to 41 megacredits, depending on the project). Standard Projects are always available to complement your cards. Your basic income, as well as your basic score, is based on your Terraform Rating(starting at 20), which increases every time you raise one of the three global parameters.However, your income is complemented with your production, and you also get VPs from many other sources.", false, 5, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 120, 60m, 8, true, "Terraforming Mars", 2016 },
                    { new Guid("00000023-0000-0000-0000-000000000000"), 14, "Twilight Imperium (Fourth Edition) is a game of galactic conquest in which three to six players take on the role of one of seventeen factions vying for galactic domination through military might, political maneuvering, and economic bargaining. Every faction offers a completely different play experience, from the wormhole-hopping Ghosts of Creuss to the Emirates of Hacan, masters of trade and economics. These seventeen races are offered many paths to victory, but only one may sit upon the throne of Mecatol Rex as the new masters of the galaxy. No two games of Twilight Imperium are ever identical. At the start of each galactic age, the game board is uniquely and strategically constructed using 51 galaxy tiles that feature everything from lush new planets and supernovas to asteroid fields and gravity rifts. Players are dealt a hand of these tiles and take turns creating the galaxy around Mecatol Rex, the capital planet seated in the center of the board. An ion storm may block your race from progressing through the galaxy while a fortuitously placed gravity rift may protect you from your closest foes. The galaxy is yours to both craft and dominate.", false, 6, 3, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 480, 120m, 8, true, "Twilight Imperium (4th edition)", 2017 },
                    { new Guid("00000029-0000-0000-0000-000000000000"), 8, "My Little Scythe is a competitive, family-friendly game in which each player controls 2 animal miniatures embarking upon an adventure in the Kingdom of Pomme. In an effort to be the first to earn 4 trophies from 8 possible categories, players take turns choosing to Move, Seek, or Make. These actions will allow players to increase their friendship and pies, power up their actions, complete quests, learn magic spells, deliver gems and apples to Castle Everfree, and perhaps even engage in a pie fight. Some of My Little Scythe’s mechanisms are inspired by the bestselling game, Scythe. It caught the eye of Stonemaier Games as a fan-created print-and-play game in 2017 ", false, 6, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 60, 50m, 7, false, "My Little Scythe", 2017 },
                    { new Guid("00000041-0000-0000-0000-000000000000"), 14, "Travel back in time to the greatest city in Mesoamerica. Witness the glory and the twilight of the powerful pre-Columbian civilization. Strategize, accrue wealth, gain the favour of the gods, and become the builder of the magnificent Pyramid of the Sun. In Teotihuacan: City of Gods, each player commands a force of worker dice, which grow in strength with every move. On your turn, you move a worker around a modular board, always choosing one of two areas of the location tile you land on: one offering you an action(and a worker upgrade), the other providing you with a powerful bonus(but without an upgrade). While managing their workforce and resources, players develop new technologies, climb the steps of the three great temples, build houses for the inhabitants of the city, and raise the legendary and breath - taking Pyramid of the Sun in the centre of the city. Each game is played in three eras.As the dawn of the Aztecs comes closer, player efforts(and their ability to feed their workforce) are evaluated a total of three times. The player with the most fame is the winner.", false, 4, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 120, 55m, 8, true, "Teotihuacan: City of Gods", 2018 },
                    { new Guid("00000031-0000-0000-0000-000000000000"), 12, "In Agricola, you're a farmer in a wooden shack with your spouse and little else. On a turn, you get to take only two actions, one for you and one for the spouse, from all the possibilities you'll find on a farm: collecting clay, wood, or stone; building fences; and so on. You might think about having kids in order to get more work accomplished, but first you need to expand your house. And what are you going to feed all the little rugrats? The game supports many levels of complexity, mainly through the use(or non - use) of two of its main types of cards, Minor Improvements and Occupations. In the beginner's version (called the Family Variant in the U.S. release), these cards are not used at all. For advanced play, the U.S. release includes three levels of both types of cards; Basic (E-deck), Interactive (I-deck), and Complex (K-deck), and the rulebook encourages players to experiment with the various decks and mixtures thereof. Aftermarket decks such as the Z-Deck and the L-Deck also exist.", false, 5, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 150, 55m, 7, true, "Agricola", 2007 },
                    { new Guid("00000032-0000-0000-0000-000000000000"), 13, "Within the charming valley of Everdell, beneath the boughs of towering trees, among meandering streams and mossy hollows, a civilization of forest critters is thriving and expanding. From Everfrost to Bellsong, many a year have come and gone, but the time has come for new territories to be settled and new cities established. You will be the leader of a group of critters intent on just such a task. There are buildings to construct, lively characters to meet, events to host—you have a busy year ahead of yourself. Will the sun shine brightest on your city before the winter moon rises?", false, 4, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 80, 35m, 7, true, "Everdell", 2015 },
                    { new Guid("00000033-0000-0000-0000-000000000000"), 8, "In Dinosaur Island, players will have to collect DNA, research the DNA sequences of extinct dinosaur species, and then combine the ancient DNA in the correct sequence to bring these prehistoric creatures back to life. Dino cooking! All players will compete to build the most thrilling park each season, and then work to attract (and keep alive!) the most visitors each season that the park opens. Do you go big and create a pack of Velociraptors ? They'll definitely excite potential visitors, but you'd better make a large enough enclosure for them. And maybe hire some(read: a lot of) security.Or they WILL break out and start eating your visitors, and we all know how that ends. You could play it safe and grow a bunch of herbivores, but then you aren't going to have the most exciting park in the world (sad face). So maybe buy a roller coaster or two to attract visitors to your park the good old-fashioned way?", false, 4, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 120, 45m, 7, true, "Dinosaur Island", 2017 },
                    { new Guid("00000034-0000-0000-0000-000000000000"), 14, "Gloomhaven is a game of Euro-inspired tactical combat in a persistent world of shifting motives. Players will take on the role of a wandering adventurer with their own special set of skills and their own reasons for traveling to this dark corner of the world. Players must work together out of necessity to clear out menacing dungeons and forgotten ruins. In the process, they will enhance their abilities with experience and loot, discover new locations to explore and plunder, and expand an ever-branching story fueled by the decisions they make. This is a game with a persistent and changing world that is ideally played over many game sessions.After a scenario, players will make decisions on what to do, which will determine how the story continues, kind of like a \"Choose Your Own Adventure\" book. Playing through a scenario is a cooperative affair where players will fight against automated monsters using an innovative card system to determine the order of play and what a player does on their turn. Each turn, a player chooses two cards to play out of their hand.The number on the top card determines their initiative for the round. Each card also has a top and bottom power, and when it is a player’s turn in the initiative order, they determine whether to use the top power of one card and the bottom power of the other, or vice - versa.Players must be careful, though, because over time they will permanently lose cards from their hands. If they take too long to clear a dungeon, they may end up exhausted and be forced to retreat.", false, 4, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 120, 120m, 8, false, "Gloomhaven", 2017 },
                    { new Guid("00000035-0000-0000-0000-000000000000"), 14, "\"Life is Battle; Battle is Glory; Glory is ALL\" In Blood Rage, each player controls their own Viking clan’s warriors, leader, and ship. Ragnarök has come, and it’s the end of the world!It’s the Vikings’ last chance to go down in a blaze of glory and secure their place in Valhalla at Odin’s side! For a Viking there are many pathways to glory. You can invade and pillage the land for its rewards, crush your opponents in epic battles, fulfill quests, increase your clan's stats, or even die gloriously either in battle or from Ragnarök, the ultimate inescapable doom. Most player strategies are guided by the cards drafted at the beginning of each of the three game rounds(or Ages). These “Gods’ Gifts” grant you numerous boons for your clan including: increased Viking strength and devious battle strategies, upgrades to your clan, or even the aid of legendary creatures from Norse mythology.They may also include various quests, from dominating specific provinces, to having lots of your Vikings sent to Valhalla. Most of these cards are aligned with one of the Norse gods, hinting at the kind of strategy they support.For example, Thor gives more glory for victory in battle, Heimdall grants you foresight and surprises, Tyr strengthens you in battle, while the trickster Loki actually rewards you for losing battles, or punishes the winner.", false, 4, 2, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 90, 75m, 8, true, "Blood Rage", 2015 },
                    { new Guid("00000036-0000-0000-0000-000000000000"), 12, "Playing Nemesis will take you into the heart of sci-fi survival horror in all its terror. A soldier fires blindly down a corridor, trying to stop the alien advance. A scientist races to find a solution in his makeshift lab. A traitor steals the last escape pod in the very last moment. Intruders you meet on the ship are not only reacting to the noise you make but also evolve as the time goes by. The longer the game takes, the stronger they become. During the game, you control one of the crew members with a unique set of skills, personal deck of cards, and individual starting equipment. These heroes cover all your basic SF horror needs. For example, the scientist is great with computers and research, but will have a hard time in combat. The soldier, on the other hand... Nemesis is a semi - cooperative game in which you and your crewmates must survive on a ship infested with hostile organisms.To win the game, you have to complete one of the two objectives dealt to you at the start of the game and get back to Earth in one piece.You will find many obstacles on your way: swarms of Intruders(the name given to the alien organisms by the ship AI), the poor physical condition of the ship, agendas held by your fellow players, and sometimes just cruel fate. The gameplay of Nemesis is designed to be full of climactic moments which, hopefully, you will find rewarding even when your best plans are ruined and your character meets a terrible fate.", false, 5, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 180, 120m, 8, true, "Nemesis", 2018 },
                    { new Guid("00000037-0000-0000-0000-000000000000"), 14, "Star Wars: Rebellion is a board game of epic conflict between the Galactic Empire and Rebel Alliance for two to four players. Experience the Galactic Civil War like never before. In Rebellion, you control the entire Galactic Empire or the fledgling Rebel Alliance.You must command starships, account for troop movements, and rally systems to your cause. Given the differences between the Empire and Rebel Alliance, each side has different win conditions, and you'll need to adjust your play style depending on who you representFeaturing more than 150 plastic miniatures and two game boards that account for thirty-two of the Star Wars galaxy's most notable systems, Rebellion features a scope that is as large and sweeping as any Star Wars game before it. Yet for all its grandiosity, Rebellion remains intensely personal, cinematic, and heroic. As much as your success depends upon the strength of your starships, vehicles, and troops, it depends upon the individual efforts of such notable characters as Leia Organa, Mon Mothma, Grand Moff Tarkin, and Emperor Palpatine.As civil war spreads throughout the galaxy, these leaders are invaluable to your efforts, and the secret missions they attempt will evoke many of the most inspiring moments from the classic trilogy. You might send Luke Skywalker to receive Jedi training on Dagobah or have Darth Vader spring a trap that freezes Han Solo in carbonite!", false, 4, 2, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 240, 115m, 8, true, "Star Wars: Rebellion", 2016 },
                    { new Guid("00000038-0000-0000-0000-000000000000"), 14, "King Robert Baratheon is dead, and the lands of Westeros brace for battle. In the second edition of A Game of Thrones: The Board Game, three to six players take on the roles of the great Houses of the Seven Kingdoms of Westeros, as they vie for control of the Iron Throne through the use of diplomacy and warfare.Based on the best - selling A Song of Ice and Fire series of fantasy novels by George R.R.Martin, A Game of Thrones is an epic board game in which it will take more than military might to win.Will you take power through force, use honeyed words to coerce your way onto the throne, or rally the townsfolk to your side ? Through strategic planning, masterful diplomacy, and clever card play, spread your influence over Westeros!Tides of Battle cards are an optional mechanism that brings an element of unpredictability to combat, representing erratic shifts in the momentum of war due to factors such as weather, morale, and tactical opportunity. During each combat, both players draw one Tides of Battle card from a communal deck, and its value modifies the strength of his chosen House card. What's more, such a card may also contain icons that can affect the outcome of the battle...all of which delivers a new level of intensity to your military engagements.", false, 6, 3, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 240, 95m, 7, true, "A Game of Thrones: The Board Game", 2011 },
                    { new Guid("00000039-0000-0000-0000-000000000000"), 14, "Rising Sun is a board game for 3 to 5 players set in legendary feudal Japan. As the Kami descend from the heavens to reshape the land in their image, it is up to each player to lead their clan to victory. Use politics to further your cause, negotiate to seek the most profitable alliances, worship the Kami to gain their favor, recruit monsters out of legend to bolster your forces, and use your resources wisely to be victorious in battle. Created by acclaimed designer Eric M. Lang, Rising Sun reunites the same creative forces responsible for the smash hit Blood Rage, with stunning artwork by Adrian Smith and intricate miniatures sculpted under the direction of Mike McVey.", false, 5, 3, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 120, 55m, 7, true, "Rising Sun", 2018 },
                    { new Guid("00000040-0000-0000-0000-000000000000"), 14, "Brass: Birmingham is an economic strategy game sequel to Martin Wallace' 2007 masterpiece, Brass. Birmingham tells the story of competing entrepreneurs in Birmingham during the industrial revolution, between the years of 1770-1870. As in its predecessor, you must develop, build, and establish your industries and network, in an effort to exploit low or high market demands.", false, 4, 2, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 120, 69m, 8, true, "Brass: Birmingham", 2018 },
                    { new Guid("00000018-0000-0000-0000-000000000000"), 10, "As an architect in Welcome To..., you want to build the best new town in the United States of the 1950s by adding resources to a pool, hiring employees, and more. Welcome To... plays like a roll-and-write dice game in which you mark results on a score-sheet...but without dice. Instead you flip cards from three piles to make three different action sets with both a house number and a corresponding action from which everyone chooses one. You use the number to fill in a house on your street in numerical order. Then you take the action to increase the point value of estates you build or score points at the end for building parks and pools. Players also have the option of taking actions to alter or duplicate their house numbers. And everyone is racing to be the first to complete public goals. There's lots to do and many paths to becoming the best suburban architect in Welcome To...! Because of the communal actions, game play is simultaneous and thus supports large groups of players. With many varying strategies and completely randomized action sets, no two games will feel the same!", false, 99, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 25, 30m, 7, true, "Welcome To...", 2018 },
                    { new Guid("00000030-0000-0000-0000-000000000000"), 10, "Root is a game of adventure and war in which 2 to 4 (1 to 6 with the 'Riverfolk' expansion) players battle for control of a vast wilderness. The nefarious Marquise de Cat has seized the great woodland, intent on harvesting its riches.Under her rule, the many creatures of the forest have banded together. This Alliance will seek to strengthen its resources and subvert the rule of Cats.In this effort, the Alliance may enlist the help of the wandering Vagabonds who are able to move through the more dangerous woodland paths. Though some may sympathize with the Alliance’s hopes and dreams, these wanderers are old enough to remember the great birds of prey who once controlled the woods. Meanwhile, at the edge of the region, the proud, squabbling Eyrie have found a new commander who they hope will lead their faction to resume their ancient birthright. The stage is set for a contest that will decide the fate of the great woodland.It is up to the players to decide which group will ultimately take root. Root represents the next step in our development of asymmetric design.Like Vast: The Crystal Caverns, each player in Root has unique capabilities and a different victory condition. Now, with the aid of gorgeous, multi - use cards, a truly asymmetric design has never been more accessible.", false, 4, 2, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 90, 55m, 8, true, "Root", 2018 },
                    { new Guid("00000017-0000-0000-0000-000000000000"), 12, "Too Many Bones comes loaded for bear by breaking into a new genre: the dice-builder RPG. This game takes everything you think you know about dice-rolling and turns it on its head. Dripping with strategy, this fantasy-based RPG puts you in the skin of a new race and takes you on an adventure to the northern territories to root out and defeat growing enemy forces and of course the infamous \"baddie\" responsible. Team up or go it alone in a 1-4 player Coop or Solo play campaign. With over 100+ unique skill dice and 4-7 classes to choose from, every battle is its own mini challenge to figure out. Your adventure will consist of 8-12 battles before you reach your final destination and face off against one of a number of possible kingpins in order to win. Along the way, you will be faced with storyline decisions that will quickly have you weighing risk/reward, odds, and logic - with dice woven into every aspect! Your party will also be faced with other decisions: when to rest, when to explore, or even which fights to pursue! The Encounter cards offer fun plot twists and some comic relief, all while setting the stage for your next battle.", false, 4, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 120, 39m, 8, false, "Too Many Bones", 2017 },
                    { new Guid("00000003-0000-0000-0000-000000000000"), 10, "You are the leader of one of the 7 great cities of the Ancient World. Gather resources, develop commercial routes, and affirm your military supremacy. Build your city and erect an architectural wonder which will transcend future times. 7 Wonders lasts three ages. In each age, players receive seven cards from a particular deck, choose one of those cards, then pass the remainder to an adjacent player. Players reveal their cards simultaneously, paying resources if needed or collecting resources or interacting with other players in various ways. Each player then chooses another card from the deck they were passed, and the process repeats until players have six cards in play from that age. After three ages, the game ends. In essence, 7 Wonders is a card development game. Some cards have immediate effects, while others provide bonuses or upgrades later in the game. Some cards provide discounts on future purchases. Some provide military strength to overpower your neighbors and others give nothing but victory points. Each card is played immediately after being drafted, so you'll know which cards your neighbor is receiving and how her choices might affect what you've already built up. Cards are passed left-right-left over the three ages, so you need to keep an eye on the neighbors in both directions.", false, 7, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 30, 30m, 7, true, "7 Wonders", 2010 },
                    { new Guid("00000015-0000-0000-0000-000000000000"), 14, "With a piece of land to call your own, a handful of resources, a few families and a head full of dreams you embark on a journey of a lifetime. Beyond lies the New World full of opportunities to make your dreams of a new home a reality. But beware, other settlers have come here as well, and although their beginnings are as humble as yours, each of them will want to influence these new lands as much as you.  Will you become the most powerful? Dice Settlers is a civilization dice game of pool building, resource gathering and area control. Each turn players reach into their bags of dice, roll and choose their own actions: from exploring new lands and building the board, through gathering resources and trading, to developing technologies which offer new abilities, each player chooses their own path to victory.", false, 4, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 60, 39m, 7, false, "Dice Settlers", 2018 },
                    { new Guid("00000001-0000-0000-0000-000000000000"), 14, "It's the early 20th century. You have decided to sail back to the newly discovered seventh continent to attempt to lift the terrible curse that has struck you since your return from the previous expedition. In The 7th Continent, a solo or cooperative \"choose-your-own-adventure\" exploration board game, you choose a character and begin your adventure on your own or with a team of other explorers. Inspired by the Fighting Fantasy book series, you will discover the extent of this wild new land through a variety of terrain and event cards. In a land fraught with danger and wonders, you have to use every ounce of wit and cunning to survive, crafting tools, weapons, and shelter to ensure your survival. Unlike most board games, it will take you many, MANY hours of exploring and searching the seventh continent until you eventually discover how to remove the curse(s)...or die trying. The 7th Continent features an easy saving system so that you can stop playing at any time and resume your adventure later on, just like in a video game!", false, 4, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 180, 99m, 8, false, "The 7th Continent", 2017 },
                    { new Guid("00000002-0000-0000-0000-000000000000"), 14, "Something evil stirs in Arkham, and only you can stop it. Blurring the traditional lines between role-playing and card game experiences, Arkham Horror: The Card Game is a Living Card Game of Lovecraftian mystery, monsters, and madness! In the game, you and your friend become characters within the quiet New England town of Arkham. You have your talents, sure, but you also have your flaws. Perhaps you've dabbled a little too much in the writings of the Necronomicon, and its words continue to haunt you. Perhaps you feel compelled to cover up any signs of otherworldly evils, hampering your own investigations in order to protect the quiet confidence of the greater population. Perhaps you'll be scarred by your encounters with a ghoulish cult. No matter what compels you, no matter what haunts you, you'll find both your strengths and weaknesses reflected in your custom deck of cards, and these cards will be your resources as you work with your friends to unravel the world's most terrifying mysteries. Each of your adventures in Arkham Horror LCG carries you deeper into mystery. You'll find cultists and foul rituals. You'll find haunted houses and strange creatures. And you may find signs of the Ancient Ones straining against the barriers to our world...", false, 2, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 120, 30m, 8, true, "Arkham Horror: The Card Game", 2016 },
                    { new Guid("00000016-0000-0000-0000-000000000000"), 8, "Impact: Battle of Elements, a reimplementation of Strike, challenges players to knock one another from the game by rolling their dice well and using the special powers available to them. Each player starts the game with five dice, with one side being blank and the other five sides showing an elemental symbol. On a turn, a player rolls one die into the arena, which is set inside the bottom of the box. If any two or more dice show the same symbol, that player then claims those dice and their turn ends. If a die shows a blank face, it's removed from play; if no symbols match, then the player can end their turn or throw another die in the arena. If the arena is empty at the start of your turn, then you must throw all of your dice into the arena, hoping to claim some back because if you ever run out of dice, then you're out of the game. Whoever last holds dice wins!", false, 5, 2, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 15, 39m, 6, true, "Impact: Battle of Elements", 2018 },
                    { new Guid("00000004-0000-0000-0000-000000000000"), 18, "Draw 7 cards. The deck plays the first card, select a Judge to play the second, then everyone selects a third card to create a three panel comic strip. The Judge picks a winner. The game includes a deck of 250 unique panel cards - that’s 15.4 million combinations of comics!", false, 10, 3, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 90, 30m, 6, true, "Joking Hazard", 2016 },
                    { new Guid("00000005-0000-0000-0000-000000000000"), 10, "Wingspan is a competitive, medium-weight, card-driven, engine-building board game from Stonemaier Games. It's designed by Elizabeth Hargrave and features over 170 birds illustrated by Natalia Rojas and Ana Maria Martinez. You are bird enthusiasts—researchers, bird watchers, ornithologists, and collectors—seeking to discover and attract the best birds to your network of wildlife preserves. Each bird extends a chain of powerful combinations in one of your habitats", false, 5, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 70, 60m, 8, true, "Wingspan", 2019 },
                    { new Guid("00000007-0000-0000-0000-000000000000"), 13, "Secret Hitler is a dramatic game of political intrigue and betrayal set in 1930s Germany. Each player is randomly and secretly assigned to be a liberal or a fascist, and one player is Secret Hitler. The fascists coordinate to sow distrust and install their cold-blooded leader; the liberals must find and stop the Secret Hitler before it's too late. The liberal team always has a majority. At the beginning of the game, players close their eyes, and the fascists reveal themselves to one another. Secret Hitler keeps his eyes closed, but puts his thumb up so the fascists can see who he is. The fascists learn who Hitler is, but Hitler doesn't know who his fellow fascists are, and the liberals don't know who anyone is. Each round, players elect a President and a Chancellor who will work together to enact a law from a random deck. If the government passes a fascist law, players must try to figure out if they were betrayed or simply unlucky. Secret Hitler also features government powers that come into play as fascism advances. The fascists will use those powers to create chaos unless liberals can pull the nation back from the brink of war. The objective of the liberal team is to pass five liberal policies or assassinate Secret Hitler. The objective of the fascist team is to pass six fascist policies or elect Secret Hitler chancellor after three fascist policies have passed.", false, 10, 5, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 45, 30m, 7, true, "Secret Hitler", 2016 },
                    { new Guid("00000006-0000-0000-0000-000000000000"), 14, "Mansions of Madness: Second Edition is a fully co-operative, app-driven board game of horror and mystery for one to five players that takes place in the same universe as Eldritch Horror and Elder Sign. Let the immersive app guide you through the veiled streets of Innsmouth and the haunted corridors of Arkham's cursed mansions as you search for answers and respite. Eight brave investigators stand ready to confront four scenarios of fear and mystery, collecting weapons, tools, and information, solving complex puzzles, and fighting monsters, insanity, and death. Open the door and step inside these hair-raising Mansions of Madness: Second Edition. It will take more than just survival to conquer the evils terrorizing this town.", false, 5, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 180, 30m, 7, true, "Mansions of Madness", 2016 },
                    { new Guid("00000009-0000-0000-0000-000000000000"), 12, "Everything good comes at a cost. What are you willing to live with? Win by playing your best perk and poisoning your neighbors. Each round of play starts by choosing a judge. The remaining players will play a perk face-down that they think the judge will like. After every player plays a perk, the players continue to play poisons face-down on their neighbor's perks. After everyone has played their cards, it's time for the judge to read all the choices aloud and pick his poison! The winning perk gets a point and play continues by rotating the role of the judge.", false, 8, 3, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 45, 30m, 5, false, "Pick Your Poison", 2016 },
                    { new Guid("00000010-0000-0000-0000-000000000000"), 12, "Playing Pictionary may remind you of Charades, but with drawing on paper instead of acting out the answers. In Pictionary, though, both teams' (or even all three teams') clue givers may be drawing at the same time as players strive to be the first to guess the correct answer. When the answer is not designated \"All Play,\" one team simply tries to come up with the answer before the timer runs out, which is usually but not always possible thanks to the varying difficulty levels of the answers.  No great drawing talent is required; instead, players gain an edge if they have a good imagination when guessing, empathy for their team mates, and/or a general ability to communicate in restricted circumstances. A board is provided, just to keep score on, which focuses the competition. Pictionary was a big hit when it first appeared and has been a classic on the party game scene ever since.", false, 16, 3, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 90, 60m, 5, true, "Pictionary", 1985 },
                    { new Guid("00000011-0000-0000-0000-000000000000"), 21, "Hours of outrageous fun! The classic ?I Never Have? game with 552 What the F*ck? styled statements. Get your friends to admit the most f*cked up things they have ever done! When you believe players are not admitting to something f*cked up that you know they've done, you get to coerce them into taking their drinks. For 3 or more players.", false, 8, 3, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 30, 30m, 6, false, "What The Fuck", 2020 },
                    { new Guid("00000012-0000-0000-0000-000000000000"), 14, "At the bottom of the ocean, no one will hear you scream! In Captain Sonar, you and your teammates control a state - of - the - art submarine and are trying to locate an enemy submarine in order to blow it out of the water before they can do the same to you.Every role is important, and the confrontation is merciless. Be organized and communicate because a captain is nothing without his crew: the Chief Mate, the Radio Operator, and the Engineer. All the members of a team sit on one side of the table, and they each take a particular role on the submarine, with the division of labor for these roles being dependent on the number of players in the game: One player might be the captain, who is responsible for moving the submarine and announcing some details of this movement; another player is manning the sonar in order to listen to the opposing captain's orders and try to decipher where that sub might be in the water; a third player might be working in the munitions room to prepare torpedoes, mines and other devices that will allow for combat.", false, 8, 2, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 60, 45m, 7, true, "Captain Sonar", 2016 },
                    { new Guid("00000013-0000-0000-0000-000000000000"), 13, "Roll for the Galaxy is a dice game of building space empires for 2–5 players. Your dice represent your populace, whom you direct to develop new technologies, settle worlds, and ship goods. The player who best manages his workers and builds the most prosperous empire wins!", false, 5, 2, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 45, 30m, 7, true, "Roll for the Galaxy", 2014 },
                    { new Guid("00000014-0000-0000-0000-000000000000"), 10, "In Dice Hospital, a worker placement game, players must treat as many patients as possible to appease the local authorities! Players use their hospital staff to treat patients on their personal hospital player boards. However, players may also call in specialist staff to react to certain situations that arise to score more points with the authorities! The game uses worker placement mechanics for the staff, dice as the patients where low scores indicate low health and a personal player board of actions to treat patients. The player with the highest reputation wins the game!", false, 4, 1, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 90, 39m, 7, true, "Dice Hospital", 2014 },
                    { new Guid("00000008-0000-0000-0000-000000000000"), 13, "Spyfall is a party game unlike any other, one in which you get to be a spy and try to understand what's going on around you. It's really simple! Spyfall is played over several rounds, and at the start of each round all players receive cards showing the same location — a casino, a traveling circus, a pirate ship, or even a space station — except that one player receives a card that says \"Spy\" instead of the location. Players then start asking each other questions — \"Why are you dressed so strangely?\" or \"When was the last time we got a payday?\" or anything else you can come up with — trying to guess who among them is the spy.  The spy doesn't know where he is, so he has to listen carefully. When it's his time to answer, he'd better create a good story! At any time during a round, one player may accuse another of being a spy. If all other players agree with the accusation, the round ends and the accused player has to reveal his identity. If the spy is uncovered, all other players score points. However, the spy can himself end a round by announcing that he understands what the secret location is; if his guess is correct, only the spy scores points.", false, 10, 3, "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95", 15, 30m, 6, true, "SpyFall", 2014 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0004-000000000000"), false, "Dice Games" },
                    { new Guid("00000000-0000-0000-0002-000000000000"), false, "Card Games" },
                    { new Guid("00000000-0000-0000-0003-000000000000"), false, "Party Games" },
                    { new Guid("00000000-0000-0000-0005-000000000000"), false, "Roll and Write Games" },
                    { new Guid("00000000-0000-0000-0001-000000000000"), false, "Puzzle Games" },
                    { new Guid("00000000-0000-0000-0007-000000000000"), false, "Base Building Games" },
                    { new Guid("00000000-0000-0000-0008-000000000000"), false, "Animal Games" },
                    { new Guid("00000000-0000-0000-0009-000000000000"), false, "Horror Games" },
                    { new Guid("00000000-0000-0000-0010-000000000000"), false, "Miniature Games" },
                    { new Guid("00000000-0000-0000-0006-000000000000"), false, "Fantasy Games" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Dob", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-250000000000"), new DateTime(1999, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Natalie Alyn Lind" },
                    { new Guid("00000000-0000-0000-0000-240000000000"), new DateTime(1983, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Jamie Chung" },
                    { new Guid("00000000-0000-0000-0000-230000000000"), new DateTime(1985, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Jessica Lucas" },
                    { new Guid("00000000-0000-0000-0000-220000000000"), new DateTime(1979, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Morena Baccarin" },
                    { new Guid("00000000-0000-0000-0000-210000000000"), new DateTime(1986, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Erin Richards" },
                    { new Guid("00000000-0000-0000-0000-190000000000"), new DateTime(1990, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Margot Robbie" },
                    { new Guid("00000000-0000-0000-0000-180000000000"), new DateTime(1956, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Eric Roberts" },
                    { new Guid("00000000-0000-0000-0000-170000000000"), new DateTime(1970, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Rick Hoffman" },
                    { new Guid("00000000-0000-0000-0000-160000000000"), new DateTime(1972, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Sarah Rafferty" },
                    { new Guid("00000000-0000-0000-0000-150000000000"), new DateTime(1981, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Patrick J. Adams" },
                    { new Guid("00000000-0000-0000-0000-140000000000"), new DateTime(1981, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Megan Markle" },
                    { new Guid("00000000-0000-0000-0000-110000000000"), new DateTime(1980, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Melissa Rauch" },
                    { new Guid("00000000-0000-0000-0000-120000000000"), new DateTime(1973, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Mayim Bialik" },
                    { new Guid("00000000-0000-0000-0000-900000000000"), new DateTime(1980, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Simon Helberg" },
                    { new Guid("00000000-0000-0000-0000-800000000000"), new DateTime(1981, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kunal Nayyar" },
                    { new Guid("00000000-0000-0000-0000-700000000000"), new DateTime(1975, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Johnny Galecki" },
                    { new Guid("00000000-0000-0000-0000-600000000000"), new DateTime(1973, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Jim Parsons" },
                    { new Guid("00000000-0000-0000-0000-500000000000"), new DateTime(1985, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kaley Cuoco" },
                    { new Guid("00000000-0000-0000-0000-400000000000"), new DateTime(1981, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Abigail Spencer" },
                    { new Guid("00000000-0000-0000-0000-300000000000"), new DateTime(1997, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Athena Faris" },
                    { new Guid("00000000-0000-0000-0000-200000000000"), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Sofie Brauwers" },
                    { new Guid("00000000-0000-0000-0000-100000000000"), new DateTime(1988, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bjorn Vossen" },
                    { new Guid("00000000-0000-0000-0000-260000000000"), new DateTime(1986, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Amber Heard" },
                    { new Guid("00000000-0000-0000-0000-130000000000"), new DateTime(1972, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Gabriel Macht" },
                    { new Guid("00000000-0000-0000-0000-270000000000"), new DateTime(1986, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Megan Fox" }
                });

            migrationBuilder.InsertData(
                table: "BoardGameArtists",
                columns: new[] { "BoardGameId", "ArtistId", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0001-0000-0000-000000000000"), false },
                    { new Guid("00000022-0000-0000-0000-000000000000"), new Guid("00000000-0010-0000-0000-000000000000"), false },
                    { new Guid("00000034-0000-0000-0000-000000000000"), new Guid("00000000-0023-0000-0000-000000000000"), false },
                    { new Guid("00000021-0000-0000-0000-000000000000"), new Guid("00000000-0003-0000-0000-000000000000"), false },
                    { new Guid("00000021-0000-0000-0000-000000000000"), new Guid("00000000-0002-0000-0000-000000000000"), false },
                    { new Guid("00000034-0000-0000-0000-000000000000"), new Guid("00000000-0026-0000-0000-000000000000"), false },
                    { new Guid("00000034-0000-0000-0000-000000000000"), new Guid("00000000-0028-0000-0000-000000000000"), false },
                    { new Guid("00000020-0000-0000-0000-000000000000"), new Guid("00000000-0014-0000-0000-000000000000"), false },
                    { new Guid("00000019-0000-0000-0000-000000000000"), new Guid("00000000-0048-0000-0000-000000000000"), false },
                    { new Guid("00000035-0000-0000-0000-000000000000"), new Guid("00000000-0030-0000-0000-000000000000"), false },
                    { new Guid("00000035-0000-0000-0000-000000000000"), new Guid("00000000-0032-0000-0000-000000000000"), false },
                    { new Guid("00000018-0000-0000-0000-000000000000"), new Guid("00000000-0047-0000-0000-000000000000"), false },
                    { new Guid("00000017-0000-0000-0000-000000000000"), new Guid("00000000-0030-0000-0000-000000000000"), false },
                    { new Guid("00000017-0000-0000-0000-000000000000"), new Guid("00000000-0029-0000-0000-000000000000"), false },
                    { new Guid("00000036-0000-0000-0000-000000000000"), new Guid("00000000-0034-0000-0000-000000000000"), false },
                    { new Guid("00000028-0000-0000-0000-000000000000"), new Guid("00000000-0007-0000-0000-000000000000"), false },
                    { new Guid("00000016-0000-0000-0000-000000000000"), new Guid("00000000-0040-0000-0000-000000000000"), false },
                    { new Guid("00000036-0000-0000-0000-000000000000"), new Guid("00000000-0036-0000-0000-000000000000"), false },
                    { new Guid("00000015-0000-0000-0000-000000000000"), new Guid("00000000-0043-0000-0000-000000000000"), false },
                    { new Guid("00000036-0000-0000-0000-000000000000"), new Guid("00000000-0038-0000-0000-000000000000"), false },
                    { new Guid("00000022-0000-0000-0000-000000000000"), new Guid("00000000-0020-0000-0000-000000000000"), false },
                    { new Guid("00000033-0000-0000-0000-000000000000"), new Guid("00000000-0021-0000-0000-000000000000"), false },
                    { new Guid("00000023-0000-0000-0000-000000000000"), new Guid("00000000-0023-0000-0000-000000000000"), false },
                    { new Guid("00000023-0000-0000-0000-000000000000"), new Guid("00000000-0050-0000-0000-000000000000"), false },
                    { new Guid("00000028-0000-0000-0000-000000000000"), new Guid("00000000-0003-0000-0000-000000000000"), false },
                    { new Guid("00000029-0000-0000-0000-000000000000"), new Guid("00000000-0009-0000-0000-000000000000"), false },
                    { new Guid("00000029-0000-0000-0000-000000000000"), new Guid("00000000-0011-0000-0000-000000000000"), false },
                    { new Guid("00000027-0000-0000-0000-000000000000"), new Guid("00000000-0001-0000-0000-000000000000"), false },
                    { new Guid("00000027-0000-0000-0000-000000000000"), new Guid("00000000-0005-0000-0000-000000000000"), false },
                    { new Guid("00000030-0000-0000-0000-000000000000"), new Guid("00000000-0013-0000-0000-000000000000"), false },
                    { new Guid("00000030-0000-0000-0000-000000000000"), new Guid("00000000-0016-0000-0000-000000000000"), false },
                    { new Guid("00000026-0000-0000-0000-000000000000"), new Guid("00000000-0010-0000-0000-000000000000"), false },
                    { new Guid("00000026-0000-0000-0000-000000000000"), new Guid("00000000-0015-0000-0000-000000000000"), false },
                    { new Guid("00000014-0000-0000-0000-000000000000"), new Guid("00000000-0027-0000-0000-000000000000"), false },
                    { new Guid("00000026-0000-0000-0000-000000000000"), new Guid("00000000-0020-0000-0000-000000000000"), false },
                    { new Guid("00000025-0000-0000-0000-000000000000"), new Guid("00000000-0030-0000-0000-000000000000"), false },
                    { new Guid("00000031-0000-0000-0000-000000000000"), new Guid("00000000-0017-0000-0000-000000000000"), false },
                    { new Guid("00000024-0000-0000-0000-000000000000"), new Guid("00000000-0035-0000-0000-000000000000"), false },
                    { new Guid("00000024-0000-0000-0000-000000000000"), new Guid("00000000-0040-0000-0000-000000000000"), false },
                    { new Guid("00000024-0000-0000-0000-000000000000"), new Guid("00000000-0045-0000-0000-000000000000"), false },
                    { new Guid("00000024-0000-0000-0000-000000000000"), new Guid("00000000-0033-0000-0000-000000000000"), false },
                    { new Guid("00000032-0000-0000-0000-000000000000"), new Guid("00000000-0019-0000-0000-000000000000"), false },
                    { new Guid("00000033-0000-0000-0000-000000000000"), new Guid("00000000-0019-0000-0000-000000000000"), false },
                    { new Guid("00000023-0000-0000-0000-000000000000"), new Guid("00000000-0013-0000-0000-000000000000"), false },
                    { new Guid("00000025-0000-0000-0000-000000000000"), new Guid("00000000-0025-0000-0000-000000000000"), false },
                    { new Guid("00000014-0000-0000-0000-000000000000"), new Guid("00000000-0026-0000-0000-000000000000"), false },
                    { new Guid("00000016-0000-0000-0000-000000000000"), new Guid("00000000-0039-0000-0000-000000000000"), false },
                    { new Guid("00000037-0000-0000-0000-000000000000"), new Guid("00000000-0040-0000-0000-000000000000"), false },
                    { new Guid("00000039-0000-0000-0000-000000000000"), new Guid("00000000-0049-0000-0000-000000000000"), false },
                    { new Guid("00000006-0000-0000-0000-000000000000"), new Guid("00000000-0022-0000-0000-000000000000"), false },
                    { new Guid("00000006-0000-0000-0000-000000000000"), new Guid("00000000-0021-0000-0000-000000000000"), false },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0016-0000-0000-000000000000"), false },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0015-0000-0000-000000000000"), false },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0014-0000-0000-000000000000"), false },
                    { new Guid("00000040-0000-0000-0000-000000000000"), new Guid("00000000-0047-0000-0000-000000000000"), false },
                    { new Guid("00000040-0000-0000-0000-000000000000"), new Guid("00000000-0043-0000-0000-000000000000"), false },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0010-0000-0000-000000000000"), false },
                    { new Guid("00000040-0000-0000-0000-000000000000"), new Guid("00000000-0041-0000-0000-000000000000"), false },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0025-0000-0000-000000000000"), false },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0024-0000-0000-000000000000"), false },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0023-0000-0000-000000000000"), false },
                    { new Guid("00000041-0000-0000-0000-000000000000"), new Guid("00000000-0039-0000-0000-000000000000"), false },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0013-0000-0000-000000000000"), false },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0012-0000-0000-000000000000"), false },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0011-0000-0000-000000000000"), false },
                    { new Guid("00000041-0000-0000-0000-000000000000"), new Guid("00000000-0037-0000-0000-000000000000"), false },
                    { new Guid("00000041-0000-0000-0000-000000000000"), new Guid("00000000-0033-0000-0000-000000000000"), false },
                    { new Guid("00000039-0000-0000-0000-000000000000"), new Guid("00000000-0050-0000-0000-000000000000"), false },
                    { new Guid("00000007-0000-0000-0000-000000000000"), new Guid("00000000-0018-0000-0000-000000000000"), false },
                    { new Guid("00000006-0000-0000-0000-000000000000"), new Guid("00000000-0020-0000-0000-000000000000"), false },
                    { new Guid("00000038-0000-0000-0000-000000000000"), new Guid("00000000-0042-0000-0000-000000000000"), false },
                    { new Guid("00000008-0000-0000-0000-000000000000"), new Guid("00000000-0026-0000-0000-000000000000"), false },
                    { new Guid("00000039-0000-0000-0000-000000000000"), new Guid("00000000-0048-0000-0000-000000000000"), false },
                    { new Guid("00000013-0000-0000-0000-000000000000"), new Guid("00000000-0033-0000-0000-000000000000"), false },
                    { new Guid("00000013-0000-0000-0000-000000000000"), new Guid("00000000-0032-0000-0000-000000000000"), false },
                    { new Guid("00000013-0000-0000-0000-000000000000"), new Guid("00000000-0031-0000-0000-000000000000"), false },
                    { new Guid("00000010-0000-0000-0000-000000000000"), new Guid("00000000-0007-0000-0000-000000000000"), false },
                    { new Guid("00000012-0000-0000-0000-000000000000"), new Guid("00000000-0027-0000-0000-000000000000"), false },
                    { new Guid("00000038-0000-0000-0000-000000000000"), new Guid("00000000-0044-0000-0000-000000000000"), false },
                    { new Guid("00000009-0000-0000-0000-000000000000"), new Guid("00000000-0050-0000-0000-000000000000"), false },
                    { new Guid("00000011-0000-0000-0000-000000000000"), new Guid("00000000-0046-0000-0000-000000000000"), false },
                    { new Guid("00000038-0000-0000-0000-000000000000"), new Guid("00000000-0046-0000-0000-000000000000"), false }
                });

            migrationBuilder.InsertData(
                table: "BoardGameCategories",
                columns: new[] { "BoardGameId", "CategoryId", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("00000030-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000"), false },
                    { new Guid("00000037-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000"), false },
                    { new Guid("00000030-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000"), false },
                    { new Guid("00000040-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000"), false },
                    { new Guid("00000029-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000"), false },
                    { new Guid("00000037-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000"), false },
                    { new Guid("00000036-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000"), false },
                    { new Guid("00000035-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000"), false },
                    { new Guid("00000038-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000"), false },
                    { new Guid("00000031-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000"), false },
                    { new Guid("00000035-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000"), false },
                    { new Guid("00000035-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000"), false },
                    { new Guid("00000031-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000"), false },
                    { new Guid("00000032-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000"), false },
                    { new Guid("00000039-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000"), false },
                    { new Guid("00000039-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000"), false },
                    { new Guid("00000039-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000"), false },
                    { new Guid("00000034-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000"), false },
                    { new Guid("00000036-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0009-000000000000"), false },
                    { new Guid("00000033-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000"), false },
                    { new Guid("00000034-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000"), false },
                    { new Guid("00000038-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000"), false },
                    { new Guid("00000033-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000"), false },
                    { new Guid("00000040-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000"), false },
                    { new Guid("00000028-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000"), false },
                    { new Guid("00000023-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000"), false },
                    { new Guid("00000028-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000"), false },
                    { new Guid("00000014-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000"), false },
                    { new Guid("00000014-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000"), false },
                    { new Guid("00000013-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000"), false },
                    { new Guid("00000013-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000"), false },
                    { new Guid("00000012-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000"), false },
                    { new Guid("00000011-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000"), false },
                    { new Guid("00000010-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000"), false },
                    { new Guid("00000009-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000"), false },
                    { new Guid("00000008-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000"), false },
                    { new Guid("00000008-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000"), false },
                    { new Guid("00000007-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000"), false },
                    { new Guid("00000028-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000"), false },
                    { new Guid("00000007-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000"), false },
                    { new Guid("00000006-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000"), false },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000"), false },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000"), false },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000"), false },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000"), false },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000"), false },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000"), false },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0009-000000000000"), false },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000"), false },
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000"), false },
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000"), false },
                    { new Guid("00000006-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0009-000000000000"), false },
                    { new Guid("00000016-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000"), false },
                    { new Guid("00000015-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000"), false },
                    { new Guid("00000017-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000"), false },
                    { new Guid("00000027-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000"), false },
                    { new Guid("00000027-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000"), false },
                    { new Guid("00000026-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000"), false },
                    { new Guid("00000026-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000"), false },
                    { new Guid("00000026-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000"), false },
                    { new Guid("00000025-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000"), false },
                    { new Guid("00000025-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000"), false },
                    { new Guid("00000024-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000"), false },
                    { new Guid("00000024-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000"), false },
                    { new Guid("00000016-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000"), false },
                    { new Guid("00000023-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000"), false },
                    { new Guid("00000041-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000"), false },
                    { new Guid("00000022-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000"), false },
                    { new Guid("00000022-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000"), false },
                    { new Guid("00000021-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000"), false },
                    { new Guid("00000021-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000"), false },
                    { new Guid("00000020-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000"), false },
                    { new Guid("00000020-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000"), false },
                    { new Guid("00000019-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000"), false },
                    { new Guid("00000019-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000"), false },
                    { new Guid("00000018-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000"), false },
                    { new Guid("00000018-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000"), false },
                    { new Guid("00000018-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000"), false },
                    { new Guid("00000023-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000"), false },
                    { new Guid("00000041-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000"), false }
                });

            migrationBuilder.InsertData(
                table: "PlayedGames",
                columns: new[] { "Id", "BoardGameId", "IsDeleted", "PlayTime" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000005-0000-0000-0000-000000000000"), false, 70 },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000023-0000-0000-0000-000000000000"), false, 480 },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000040-0000-0000-0000-000000000000"), false, 160 }
                });

            migrationBuilder.InsertData(
                table: "GamesScores",
                columns: new[] { "PlayedGameId", "PlayerId", "IsDeleted", "Score" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-100000000000"), false, 30 },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-200000000000"), false, 25 },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-400000000000"), false, 40 },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-500000000000"), false, 20 },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-100000000000"), false, 6 },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-200000000000"), false, 8 },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-300000000000"), false, 10 },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-400000000000"), false, 4 },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-500000000000"), false, 2 },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-100000000000"), false, 20 },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-200000000000"), false, 30 },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-400000000000"), false, 40 }
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
