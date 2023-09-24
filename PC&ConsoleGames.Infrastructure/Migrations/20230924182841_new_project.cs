using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PC_ConsoleGames.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class new_project : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    SystemRequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "GamesGenres",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamesGenres", x => new { x.GameId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_GamesGenres_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamesGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamesLanguages",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamesLanguages", x => new { x.GameId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_GamesLanguages_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamesLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Developer", "Name", "Poster", "Publisher", "Rating", "ReleaseDate", "SystemRequirements" },
                values: new object[,]
                {
                    { 1, "Cyberpunk 2077 is an open-world, action-adventure RPG set in the dark future of Night City — a dangerous megalopolis obsessed with power, glamor, and ceaseless body modification.\r\n", "CD Projekt RED", "Cyberpunk 2077", "https://cdn.cloudflare.steamstatic.com/steam/apps/1091500/header.jpg?t=1695308476", "CD Projekt RED", 80.0, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: 64-bit Windows 10\r\nProcessor: Core i7-6700 or Ryzen 5 1600\r\nMemory: 12 GB RAM\r\nGraphics: GeForce GTX 1060 6GB or Radeon RX 580 8GB or Arc A380\r\nDirectX: Version 12\r\nStorage: 70 GB available space\r\nAdditional Notes: SSD required. Attention: In this game you will encounter a variety of visual effects that may provide seizures or loss of consciousness in a minority of people. If you or someone you know experiences any of the above symptoms while playing, stop and seek medical attention immediately.\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: 64-bit Windows 10\r\nProcessor: Core i7-12700 or Ryzen 7 7800X3D\r\nMemory: 16 GB RAM\r\nGraphics: GeForce RTX 2060 SUPER or Radeon RX 5700 XT or Arc A770\r\nDirectX: Version 12\r\nStorage: 70 GB available space\r\nAdditional Notes: SSD required.\r\n" },
                    { 2, "Discover a reborn Mortal Kombat™ Universe created by the Fire God Liu Kang. Mortal Kombat™ 1 ushers in a new era of the iconic franchise with a new fighting system, game modes, and fatalities!\r\n", "NetherRealm Studios, QLOC", "Mortal Kombat 1", "https://cdn.cloudflare.steamstatic.com/steam/apps/1971870/header.jpg?t=1695256145", "Warner Bros. Games", 76.0, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 64-bit\r\nProcessor: Intel® Core™ i5-6600 | AMD Ryzen™ 3 3100 or Ryzen™ 5 2600\r\nMemory: 8 GB RAM\r\nGraphics: Nvidia GeForce® GTX 980 or AMD Radeon™ RX 470 or Intel® Arc™ A750\r\nDirectX: Version 12\r\nStorage: 100 GB available space\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10/11 64-bit\r\nProcessor: Intel® Core™ i5-8400 | AMD Ryzen™ 5 3600X\r\nMemory: 8 GB RAM\r\nGraphics: Nvidia GeForce® GTX 1080 Ti or AMD Radeon™ RX 5700 XT or Intel® Arc™ A770\r\nDirectX: Version 12\r\nStorage: 100 GB available space\r\n" },
                    { 3, "Starfield is the first new universe in 25 years from Bethesda Game Studios, the award-winning creators of The Elder Scrolls V: Skyrim and Fallout 4.\r\n", "Bethesda Game Studios", "Starfield", "https://cdn.cloudflare.steamstatic.com/steam/apps/1716740/header.jpg?t=1694716152", "Bethesda Softworks", 75.0, new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINIMUM:\r\nOS: Windows 10 version 21H1 (10.0.19043)\r\nProcessor: AMD Ryzen 5 2600X, Intel Core i7-6800K\r\nMemory: 16 GB RAM\r\nGraphics: AMD Radeon RX 5700, NVIDIA GeForce 1070 Ti\r\nDirectX: Version 12\r\nStorage: 125 GB available space\r\nAdditional Notes: SSD Required\r\nRECOMMENDED:\r\nOS: Windows 10/11 with updates\r\nProcessor: AMD Ryzen 5 3600X, Intel i5-10600K\r\nMemory: 16 GB RAM\r\nGraphics: AMD Radeon RX 6800 XT, NVIDIA GeForce RTX 2080\r\nDirectX: Version 12\r\nNetwork: Broadband Internet connection\r\nStorage: 125 GB available space\r\nAdditional Notes: SSD Required\r\n" },
                    { 4, "Baldur’s Gate 3 is a story-rich, party-based RPG set in the universe of Dungeons & Dragons, where your choices shape a tale of fellowship and betrayal, survival and sacrifice, and the lure of absolute power.\r\n", "Larian Studios", "Baldur`s Gate 3", "https://cdn.cloudflare.steamstatic.com/steam/apps/1086940/header.jpg?t=1695393586", "Larian Studios", 96.0, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 64-bit\r\nProcessor: Intel I5 4690 / AMD FX 8350\r\nMemory: 8 GB RAM\r\nGraphics: Nvidia GTX 970 / RX 480 (4GB+ of VRAM)\r\nDirectX: Version 11\r\nStorage: 150 GB available space\r\nAdditional Notes: SSD required\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 64-bit\r\nProcessor: Intel i7 8700K / AMD r5 3600\r\nMemory: 16 GB RAM\r\nGraphics: Nvidia 2060 Super / RX 5700 XT (8GB+ of VRAM)\r\nDirectX: Version 11\r\nStorage: 150 GB available space\r\nAdditional Notes: SSD required\r\n" },
                    { 5, "Survival is just the beginning. Six years have passed since the biological disaster in Raccoon City. Leon S. Kennedy, one of the survivors, tracks the president's kidnapped daughter to a secluded European village, where there is something terribly wrong with the locals.\r\n", "CAPCOM Co., Ltd.", "Resident Evil 4", "https://cdn.cloudflare.steamstatic.com/steam/apps/2050650/header_alt_assets_0.jpg?t=1695311474", "CAPCOM Co., Ltd.", 97.0, new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 (64 bit)\r\nProcessor: AMD Ryzen 3 1200 / Intel Core i5-7500\r\nMemory: 8 GB RAM\r\nGraphics: AMD Radeon RX 560 with 4GB VRAM / NVIDIA GeForce GTX 1050 Ti with 4GB VRAM\r\nDirectX: Version 12\r\nNetwork: Broadband Internet connection\r\nAdditional Notes: Estimated performance (when set to Prioritize Performance): 1080p/45fps. ・Framerate might drop in graphics-intensive scenes. ・AMD Radeon RX 6700 XT or NVIDIA GeForce RTX 2060 required to support ray tracing.\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 (64 bit)/Windows 11 (64 bit)\r\nProcessor: AMD Ryzen 5 3600 / Intel Core i7 8700\r\nMemory: 16 GB RAM\r\nGraphics: AMD Radeon RX 5700 / NVIDIA GeForce GTX 1070\r\nDirectX: Version 12\r\nNetwork: Broadband Internet connection\r\nAdditional Notes: Estimated performance: 1080p/60fps ・Framerate might drop in graphics-intensive scenes. ・AMD Radeon RX 6700 XT or NVIDIA GeForce RTX 2070 required to support ray tracing.\r\n" },
                    { 6, "Lies of P is a thrilling soulslike that takes the story of Pinocchio, turns it on its head, and sets it against the darkly elegant backdrop of the Belle Epoque era.\r\n", "NEOWIZ", "Lies of P", "https://cdn.cloudflare.steamstatic.com/steam/apps/1627720/header.jpg?t=1695272170", "NEOWIZ", 86.0, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 64bit\r\nProcessor: AMD Ryzen 3 1200／Intel Core i3-6300\r\nMemory: 8 GB RAM\r\nGraphics: AMD Radeon RX 560 4GB / NVIDIA GeForce GTX 960 4GB\r\nDirectX: Version 12\r\nStorage: 50 GB available space\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 64bit\r\nProcessor: AMD Ryzen 3 1200／Intel Core i3-6300\r\nMemory: 16 GB RAM\r\nGraphics: AMD Radeon RX 6500 XT 4GB / NVIDIA GeForce GTX 1660 6GB\r\nDirectX: Version 12\r\nStorage: 50 GB available space\r\n" },
                    { 7, "Raise a city from the ground up and transform it into a thriving metropolis with the most realistic city builder ever. Push your creativity and problem-solving to build on a scale you've never experienced. With deep simulation and a living economy, this is world-building without limits.", "Colossal Order Ltd.", "Cities: Skylines II", "https://cdn.cloudflare.steamstatic.com/steam/apps/949230/header.jpg?t=1695281898", "Paradox Interactive", 0.0, new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows® 10 Home 64 Bit\r\nProcessor: Intel® Core™ i7-4790K / AMD® Ryzen™ 5 1600X\r\nMemory: 8 GB RAM\r\nGraphics: Nvidia® GeForce™ GTX 780 (3GB) or AMD® Radeon™ RX 470 (4GB)\r\nSound Card: TBC\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows® 10 Home 64 Bit | Windows® 11\r\nProcessor: Intel® Core™ i7-9700K | AMD® Ryzen™ 5 5600X\r\nMemory: 16 GB RAM\r\nGraphics: Nvidia® GeForce™ RTX 2080 Ti (11GB) | AMD® Radeon™ RX 6800 XT (16GB)\r\nSound Card: TBC" },
                    { 8, "Your Ultimate Horizon Adventure awaits! Explore the vibrant open world landscapes of Mexico with limitless, fun driving action in the world’s greatest cars. Conquer the rugged Sierra Nueva in the ultimate Horizon Rally experience. Requires Forza Horizon 5 game, expansion sold separately.", "Playground Games", "Forza Horizon 5", "https://cdn.cloudflare.steamstatic.com/steam/apps/1551360/header.jpg?t=1694801571", "Xbox Game Studios", 88.0, new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 version 15063.0 or higher\r\nProcessor: Intel i5-4460 or AMD Ryzen 3 1200\r\nMemory: 8 GB RAM\r\nGraphics: NVidia GTX 970 OR AMD RX 470\r\nDirectX: Version 12\r\nNetwork: Broadband Internet connection\r\nStorage: 110 GB available space\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 version 15063.0 or higher\r\nProcessor: Intel i5-8400 or AMD Ryzen 5 1500X\r\nMemory: 16 GB RAM\r\nGraphics: NVidia GTX 1070 OR AMD RX 590\r\nDirectX: Version 12\r\nNetwork: Broadband Internet connection\r\nStorage: 110 GB available space\r\n" },
                    { 9, "THE NEW FANTASY ACTION RPG. Rise, Tarnished, and be guided by grace to brandish the power of the Elden Ring and become an Elden Lord in the Lands Between.\r\n", "FromSoftware Inc.", "Elden Ring", "https://cdn.cloudflare.steamstatic.com/steam/apps/1245620/header.jpg?t=1683618443", "FromSoftware Inc., Bandai Namco Entertainment", 92.0, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10\r\nProcessor: INTEL CORE I5-8400 or AMD RYZEN 3 3300X\r\nMemory: 12 GB RAM\r\nGraphics: NVIDIA GEFORCE GTX 1060 3 GB or AMD RADEON RX 580 4 GB\r\nDirectX: Version 12\r\nStorage: 60 GB available space\r\nSound Card: Windows Compatible Audio Device\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10/11\r\nProcessor: INTEL CORE I7-8700K or AMD RYZEN 5 3600X\r\nMemory: 16 GB RAM\r\nGraphics: NVIDIA GEFORCE GTX 1070 8 GB or AMD RADEON RX VEGA 56 8 GB\r\nDirectX: Version 12\r\nStorage: 60 GB available space\r\nSound Card: Windows Compatible Audio Device\r\n" },
                    { 10, "The Mass Effect™ Legendary Edition includes single-player base content and over 40 DLC from the highly acclaimed Mass Effect, Mass Effect 2, and Mass Effect 3 games, including promo weapons, armors, and packs — remastered and optimized for 4K Ultra HD.\r\n", "BioWare", "Mass Effect™ Legendary Edition", "https://cdn.cloudflare.steamstatic.com/steam/apps/1328670/header.jpg?t=1669773470", "Electronic Arts", 83.0, new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: 64-bit Windows 10\r\nProcessor: Intel Core i5 3570 or AMD FX-8350\r\nMemory: 8 GB RAM\r\nGraphics: GPU: NVIDIA GTX 760, AMD Radeon 7970 / R9280X GPU RAM: 2 GB Video Memory\r\nDirectX: Version 11\r\nStorage: 120 GB available space\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: 64-bit Windows 10\r\nProcessor: Intel Core i7-7700 or AMD Ryzen 7 3700X\r\nMemory: 16 GB RAM\r\nGraphics: GPU: NVIDIA GTX 1070 / RTX 200, Radeon Vega 56, GPU RAM: 4 GB Video Memory\r\nDirectX: Version 11\r\nStorage: 120 GB available space\r\n" },
                    { 11, "Hogwarts Legacy is an immersive, open-world action RPG. Now you can take control of the action and be at the center of your own adventure in the wizarding world.\r\n", "Avalanche Software", "Hogwarts Legacy", "https://cdn.cloudflare.steamstatic.com/steam/apps/990080/header.jpg?t=1694060626", "Warner Bros. Games", 92.0, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: 64-bit Windows 10\r\nProcessor: Intel Core i5-6600 (3.3Ghz) or AMD Ryzen 5 1400 (3.2Ghz)\r\nMemory: 16 GB RAM\r\nGraphics: NVIDIA GeForce GTX 960 4GB or AMD Radeon RX 470 4GB\r\nDirectX: Version 12\r\nStorage: 85 GB available space\r\nAdditional Notes: SSD (Preferred), HDD (Supported), 720p/30 fps, Low Quality Settings\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: 64-bit Windows 10\r\nProcessor: Intel Core i7-8700 (3.2Ghz) or AMD Ryzen 5 3600 (3.6 Ghz)\r\nMemory: 16 GB RAM\r\nGraphics: NVIDIA GeForce 1080 Ti or AMD Radeon RX 5700 XT or INTEL Arc A770\r\nDirectX: Version 12\r\nStorage: 85 GB available space\r\nAdditional Notes: SSD, 1080p/60 fps, High Quality Settings\r\n" },
                    { 12, "Love, fight, scheme, and claim greatness. Determine your noble house’s legacy in the sprawling grand strategy of Crusader Kings III. Death is only the beginning as you guide your dynasty’s bloodline in the rich and larger-than-life simulation of the Middle Ages.", "Paradox Development Studio", "Crusader Kings III", "https://cdn.cloudflare.steamstatic.com/steam/apps/1158310/header.jpg?t=1692714098", "Paradox Interactive", 92.0, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows® 8.1 64 bit / Windows® 10 Home 64 bit\r\nProcessor: Intel® Core™ i3-2120 / AMD® FX 6350\r\nMemory: 6 GB RAM\r\nGraphics: Nvidia® GeForce™ GTX 660 (2GB) / AMD® Radeon™ HD 7870 (2GB) / Intel® Iris Pro™ 580 / Intel® Iris® Plus G7 / AMD® Radeon™ Vega 11\r\nStorage: 8 GB available space\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows® 10 Home 64 bit\r\nProcessor: Intel® Core™ i5-4670K / AMD® Ryzen™ 5 2400G\r\nMemory: 8 GB RAM\r\nGraphics: Nvidia® GeForce™ GTX 1650 (4GB) / AMD® Radeon™ R9 390X (8GB)\r\nStorage: 8 GB available space\r\n" },
                    { 13, "Winner of over 175 Game of the Year Awards and recipient of over 250 perfect scores, RDR2 is the epic tale of outlaw Arthur Morgan and the infamous Van der Linde gang, on the run across America at the dawn of the modern age. Also includes access to the shared living world of Red Dead Online.\r\n", "Rockstar Games", "Red Dead Redemption 2", "https://cdn.cloudflare.steamstatic.com/steam/apps/1174180/header.jpg?t=1695140956", "Rockstar Games", 90.0, new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 - April 2018 Update (v1803)\r\nProcessor: Intel® Core™ i7-4770K / AMD Ryzen 5 1500X\r\nMemory: 12 GB RAM\r\nGraphics: Nvidia GeForce GTX 1060 6GB / AMD Radeon RX 480 4GB\r\nNetwork: Broadband Internet connection\r\nStorage: 150 GB available space\r\nSound Card: Direct X Compatible\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 - April 2018 Update (v1803)\r\nProcessor: Intel® Core™ i7-4770K / AMD Ryzen 5 1500X\r\nMemory: 12 GB RAM\r\nGraphics: Nvidia GeForce GTX 1060 6GB / AMD Radeon RX 480 4GB\r\nNetwork: Broadband Internet connection\r\nStorage: 150 GB available space\r\nSound Card: Direct X Compatible\r\n" },
                    { 14, "An inadvertent brush with the mob thrusts cabdriver Tommy Angelo into the world of organized crime. Initially uneasy about falling in with the Salieri family, the rewards become too big to ignore.\r\n", "Hangar 13", "Mafia: Definitive Edition", "https://cdn.cloudflare.steamstatic.com/steam/apps/1030840/header.jpg?t=1632420251", "2K", 86.0, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 64-bit\r\nProcessor: Intel Core-i5 2550K 3.4GHz / AMD FX 8120 3.1 GHz\r\nMemory: 6 GB RAM\r\nGraphics: NVIDIA GeForce GTX 660 / AMD Radeon HD 7870\r\nDirectX: Version 11\r\nStorage: 50 GB available space\r\nSound Card: DirectX Compatible\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 64-bit\r\nProcessor: Intel Core-i7 3770 3.4GHz / AMD FX-8350 4.2GHz\r\nMemory: 16 GB RAM\r\nGraphics: NVIDIA GeForce GTX 1080 / AMD Radeon RX 5700\r\nDirectX: Version 11\r\nStorage: 50 GB available space\r\nSound Card: DirectX Compatible\r\n" },
                    { 15, "You are Geralt of Rivia, mercenary monster slayer. Before you stands a war-torn, monster-infested continent you can explore at will. Your current contract? Tracking down Ciri — the Child of Prophecy, a living weapon that can alter the shape of the world.\r\n", "Hangar 13", "The Witcher® 3: Wild Hunt", "https://cdn.cloudflare.steamstatic.com/steam/apps/292030/header.jpg?t=1693590732", "2K", 96.0, new DateTime(2015, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINIMUM:\r\nOS: 64-bit Windows 7, 64-bit Windows 8 (8.1)\r\nProcessor: Intel CPU Core i5-2500K 3.3GHz / AMD A10-5800K APU (3.8GHz)\r\nMemory: 6 GB RAM\r\nGraphics: Nvidia GPU GeForce GTX 660 / AMD GPU Radeon HD 7870\r\nDirectX: Version 11\r\nStorage: 50 GB available space\r\nRECOMMENDED:\r\nOS: 64-bit Windows 10/11\r\nProcessor: Intel Core i5-7400 / Ryzen 5 1600\r\nMemory: 8 GB RAM\r\nGraphics: Nvidia GTX 1070 / Radeon RX 480\r\nDirectX: Version 12\r\nStorage: 50 GB available space\r\n" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "RPG" },
                    { 2, "Action" },
                    { 3, "Adventure" },
                    { 4, "Indie" },
                    { 5, "Simulation" },
                    { 6, "Strategy" },
                    { 7, "Racing" },
                    { 8, "Sports" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "Ukrainian" },
                    { 3, "French" },
                    { 4, "Italian" },
                    { 5, "German" },
                    { 6, "Spanish" },
                    { 7, "Arabic" },
                    { 8, "Japanese" },
                    { 9, "Korean" },
                    { 10, "Portuguese" },
                    { 11, "Chinese" },
                    { 12, "Spanish" },
                    { 13, "Czech" },
                    { 14, "Polish" },
                    { 15, "Hungarian" },
                    { 16, "Thai" },
                    { 17, "Turkish" },
                    { 18, "Dutch" }
                });

            migrationBuilder.InsertData(
                table: "GamesGenres",
                columns: new[] { "GameId", "GenreId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 4, 1 },
                    { 4, 3 },
                    { 4, 6 },
                    { 5, 2 },
                    { 5, 3 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 5 },
                    { 8, 2 },
                    { 8, 3 },
                    { 8, 5 },
                    { 8, 7 },
                    { 8, 8 },
                    { 9, 1 },
                    { 9, 2 },
                    { 10, 1 },
                    { 10, 2 },
                    { 11, 1 },
                    { 11, 2 },
                    { 11, 3 },
                    { 12, 1 },
                    { 12, 5 },
                    { 12, 6 },
                    { 13, 2 },
                    { 13, 3 },
                    { 14, 2 },
                    { 14, 3 },
                    { 15, 1 }
                });

            migrationBuilder.InsertData(
                table: "GamesLanguages",
                columns: new[] { "GameId", "LanguageId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 2, 1 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 14 },
                    { 3, 1 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 8 },
                    { 3, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 14 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 12 },
                    { 4, 17 },
                    { 5, 1 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 5, 8 },
                    { 5, 9 },
                    { 5, 10 },
                    { 5, 11 },
                    { 5, 12 },
                    { 6, 1 },
                    { 6, 3 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 6, 12 },
                    { 6, 14 },
                    { 7, 1 },
                    { 7, 3 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 8 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 11 },
                    { 7, 12 },
                    { 7, 14 },
                    { 8, 1 },
                    { 8, 3 },
                    { 8, 4 },
                    { 8, 5 },
                    { 8, 6 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 8, 12 },
                    { 8, 13 },
                    { 8, 14 },
                    { 8, 15 },
                    { 8, 17 },
                    { 9, 1 },
                    { 9, 3 },
                    { 9, 4 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 8 },
                    { 9, 9 },
                    { 9, 10 },
                    { 9, 11 },
                    { 9, 12 },
                    { 9, 14 },
                    { 9, 16 },
                    { 10, 1 },
                    { 10, 3 },
                    { 10, 4 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 8 },
                    { 10, 12 },
                    { 10, 14 },
                    { 11, 1 },
                    { 11, 3 },
                    { 11, 4 },
                    { 11, 5 },
                    { 11, 6 },
                    { 11, 7 },
                    { 11, 8 },
                    { 11, 9 },
                    { 11, 10 },
                    { 11, 11 },
                    { 11, 12 },
                    { 11, 14 },
                    { 12, 1 },
                    { 12, 3 },
                    { 12, 4 },
                    { 12, 5 },
                    { 12, 6 },
                    { 12, 9 },
                    { 12, 11 },
                    { 13, 1 },
                    { 13, 3 },
                    { 13, 4 },
                    { 13, 5 },
                    { 13, 6 },
                    { 13, 8 },
                    { 13, 9 },
                    { 13, 10 },
                    { 13, 11 },
                    { 14, 1 },
                    { 14, 3 },
                    { 14, 4 },
                    { 14, 5 },
                    { 14, 6 },
                    { 14, 8 },
                    { 14, 9 },
                    { 14, 10 },
                    { 14, 11 },
                    { 14, 12 },
                    { 14, 13 },
                    { 14, 14 },
                    { 15, 1 },
                    { 15, 3 },
                    { 15, 4 },
                    { 15, 5 },
                    { 15, 6 },
                    { 15, 7 },
                    { 15, 8 },
                    { 15, 9 },
                    { 15, 10 },
                    { 15, 11 },
                    { 15, 12 },
                    { 15, 13 },
                    { 15, 14 },
                    { 15, 17 }
                });

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
                name: "IX_GamesGenres_GenreId",
                table: "GamesGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_GamesLanguages_LanguageId",
                table: "GamesLanguages",
                column: "LanguageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "GamesGenres");

            migrationBuilder.DropTable(
                name: "GamesLanguages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
