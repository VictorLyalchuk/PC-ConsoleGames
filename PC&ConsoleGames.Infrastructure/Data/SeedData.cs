using PC_ConsoleGames.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Infrastructure.Data
{
    public static class SeedData
    {
        public static List<Game> GetGames()
        {
            return new List<Game>() {
                new Game(){
                    Id=1,
                    Name="Cyberpunk 2077",
                    ReleaseDate= new DateTime(2020, 12, 10),
                    Developer="CD Projekt RED",
                    Publisher="CD Projekt RED",
                    Poster=@"https://cdn.cloudflare.steamstatic.com/steam/apps/1091500/header.jpg?t=1695308476",
                    Description="Cyberpunk 2077 is an open-world, action-adventure RPG set in the dark future of Night City — a dangerous megalopolis obsessed with power, glamor, and ceaseless body modification.\r\n",
                    SystemRequirements="MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: 64-bit Windows 10\r\nProcessor: Core i7-6700 or Ryzen 5 1600\r\nMemory: 12 GB RAM\r\nGraphics: GeForce GTX 1060 6GB or Radeon RX 580 8GB or Arc A380\r\nDirectX: Version 12\r\nStorage: 70 GB available space\r\nAdditional Notes: SSD required. Attention: In this game you will encounter a variety of visual effects that may provide seizures or loss of consciousness in a minority of people. If you or someone you know experiences any of the above symptoms while playing, stop and seek medical attention immediately.\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: 64-bit Windows 10\r\nProcessor: Core i7-12700 or Ryzen 7 7800X3D\r\nMemory: 16 GB RAM\r\nGraphics: GeForce RTX 2060 SUPER or Radeon RX 5700 XT or Arc A770\r\nDirectX: Version 12\r\nStorage: 70 GB available space\r\nAdditional Notes: SSD required.\r\n",
                    Rating=80,
                },
                new Game(){
                    Id=2,
                    Name="Mortal Kombat 1",
                    ReleaseDate= new DateTime(2023, 9, 19),
                    Developer="NetherRealm Studios, QLOC",
                    Publisher="Warner Bros. Games",
                    Poster=@"https://cdn.cloudflare.steamstatic.com/steam/apps/1971870/header.jpg?t=1695256145",
                    Description="Discover a reborn Mortal Kombat™ Universe created by the Fire God Liu Kang. Mortal Kombat™ 1 ushers in a new era of the iconic franchise with a new fighting system, game modes, and fatalities!\r\n",
                    SystemRequirements="MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 64-bit\r\nProcessor: Intel® Core™ i5-6600 | AMD Ryzen™ 3 3100 or Ryzen™ 5 2600\r\nMemory: 8 GB RAM\r\nGraphics: Nvidia GeForce® GTX 980 or AMD Radeon™ RX 470 or Intel® Arc™ A750\r\nDirectX: Version 12\r\nStorage: 100 GB available space\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10/11 64-bit\r\nProcessor: Intel® Core™ i5-8400 | AMD Ryzen™ 5 3600X\r\nMemory: 8 GB RAM\r\nGraphics: Nvidia GeForce® GTX 1080 Ti or AMD Radeon™ RX 5700 XT or Intel® Arc™ A770\r\nDirectX: Version 12\r\nStorage: 100 GB available space\r\n",
                    Rating=76,
                },
                new Game(){
                    Id=3,
                    Name="Starfield",
                    ReleaseDate= new DateTime(2023, 9, 6),
                    Developer="Bethesda Game Studios",
                    Publisher="Bethesda Softworks",
                    Poster=@"https://cdn.cloudflare.steamstatic.com/steam/apps/1716740/header.jpg?t=1694716152",
                    Description="Starfield is the first new universe in 25 years from Bethesda Game Studios, the award-winning creators of The Elder Scrolls V: Skyrim and Fallout 4.\r\n",
                    SystemRequirements="MINIMUM:\r\nOS: Windows 10 version 21H1 (10.0.19043)\r\nProcessor: AMD Ryzen 5 2600X, Intel Core i7-6800K\r\nMemory: 16 GB RAM\r\nGraphics: AMD Radeon RX 5700, NVIDIA GeForce 1070 Ti\r\nDirectX: Version 12\r\nStorage: 125 GB available space\r\nAdditional Notes: SSD Required\r\nRECOMMENDED:\r\nOS: Windows 10/11 with updates\r\nProcessor: AMD Ryzen 5 3600X, Intel i5-10600K\r\nMemory: 16 GB RAM\r\nGraphics: AMD Radeon RX 6800 XT, NVIDIA GeForce RTX 2080\r\nDirectX: Version 12\r\nNetwork: Broadband Internet connection\r\nStorage: 125 GB available space\r\nAdditional Notes: SSD Required\r\n",
                    Rating=75,
                },
                new Game(){
                    Id=4,
                    Name="Baldur`s Gate 3",
                    ReleaseDate= new DateTime(2023, 8, 3),
                    Developer="Larian Studios",
                    Publisher="Larian Studios",
                    Poster=@"https://cdn.cloudflare.steamstatic.com/steam/apps/1086940/header.jpg?t=1695393586",                    
                    Description="Baldur’s Gate 3 is a story-rich, party-based RPG set in the universe of Dungeons & Dragons, where your choices shape a tale of fellowship and betrayal, survival and sacrifice, and the lure of absolute power.\r\n",
                    SystemRequirements="MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 64-bit\r\nProcessor: Intel I5 4690 / AMD FX 8350\r\nMemory: 8 GB RAM\r\nGraphics: Nvidia GTX 970 / RX 480 (4GB+ of VRAM)\r\nDirectX: Version 11\r\nStorage: 150 GB available space\r\nAdditional Notes: SSD required\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 64-bit\r\nProcessor: Intel i7 8700K / AMD r5 3600\r\nMemory: 16 GB RAM\r\nGraphics: Nvidia 2060 Super / RX 5700 XT (8GB+ of VRAM)\r\nDirectX: Version 11\r\nStorage: 150 GB available space\r\nAdditional Notes: SSD required\r\n",
                    Rating=96,
                },
                new Game(){
                    Id=5,
                    Name="Resident Evil 4",
                    ReleaseDate= new DateTime(2023, 3, 24),
                    Developer="CAPCOM Co., Ltd.",
                    Publisher="CAPCOM Co., Ltd.",
                    Poster=@"https://cdn.cloudflare.steamstatic.com/steam/apps/2050650/header_alt_assets_0.jpg?t=1695311474",                    
                    Description="Survival is just the beginning. Six years have passed since the biological disaster in Raccoon City. Leon S. Kennedy, one of the survivors, tracks the president's kidnapped daughter to a secluded European village, where there is something terribly wrong with the locals.\r\n",
                    SystemRequirements="MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 (64 bit)\r\nProcessor: AMD Ryzen 3 1200 / Intel Core i5-7500\r\nMemory: 8 GB RAM\r\nGraphics: AMD Radeon RX 560 with 4GB VRAM / NVIDIA GeForce GTX 1050 Ti with 4GB VRAM\r\nDirectX: Version 12\r\nNetwork: Broadband Internet connection\r\nAdditional Notes: Estimated performance (when set to Prioritize Performance): 1080p/45fps. ・Framerate might drop in graphics-intensive scenes. ・AMD Radeon RX 6700 XT or NVIDIA GeForce RTX 2060 required to support ray tracing.\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 (64 bit)/Windows 11 (64 bit)\r\nProcessor: AMD Ryzen 5 3600 / Intel Core i7 8700\r\nMemory: 16 GB RAM\r\nGraphics: AMD Radeon RX 5700 / NVIDIA GeForce GTX 1070\r\nDirectX: Version 12\r\nNetwork: Broadband Internet connection\r\nAdditional Notes: Estimated performance: 1080p/60fps ・Framerate might drop in graphics-intensive scenes. ・AMD Radeon RX 6700 XT or NVIDIA GeForce RTX 2070 required to support ray tracing.\r\n",
                    Rating=97,
                },
                new Game(){
                    Id=6,
                    Name="Lies of P",
                    ReleaseDate= new DateTime(2023, 9, 18),
                    Developer="NEOWIZ",
                    Publisher="NEOWIZ",
                    Poster=@"https://cdn.cloudflare.steamstatic.com/steam/apps/1627720/header.jpg?t=1695272170",
                    Description="Lies of P is a thrilling soulslike that takes the story of Pinocchio, turns it on its head, and sets it against the darkly elegant backdrop of the Belle Epoque era.\r\n",
                    SystemRequirements="MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 64bit\r\nProcessor: AMD Ryzen 3 1200／Intel Core i3-6300\r\nMemory: 8 GB RAM\r\nGraphics: AMD Radeon RX 560 4GB / NVIDIA GeForce GTX 960 4GB\r\nDirectX: Version 12\r\nStorage: 50 GB available space\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 64bit\r\nProcessor: AMD Ryzen 3 1200／Intel Core i3-6300\r\nMemory: 16 GB RAM\r\nGraphics: AMD Radeon RX 6500 XT 4GB / NVIDIA GeForce GTX 1660 6GB\r\nDirectX: Version 12\r\nStorage: 50 GB available space\r\n",
                    Rating=86,
                },
                new Game(){
                    Id=7,
                    Name="Cities: Skylines II",
                    ReleaseDate= new DateTime(2023, 10, 24),
                    Developer="Colossal Order Ltd.",
                    Publisher="Paradox Interactive",
                    Poster=@"https://cdn.cloudflare.steamstatic.com/steam/apps/949230/header.jpg?t=1695281898",
                    Description="Raise a city from the ground up and transform it into a thriving metropolis with the most realistic city builder ever. Push your creativity and problem-solving to build on a scale you've never experienced. With deep simulation and a living economy, this is world-building without limits.",
                    SystemRequirements="MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows® 10 Home 64 Bit\r\nProcessor: Intel® Core™ i7-4790K / AMD® Ryzen™ 5 1600X\r\nMemory: 8 GB RAM\r\nGraphics: Nvidia® GeForce™ GTX 780 (3GB) or AMD® Radeon™ RX 470 (4GB)\r\nSound Card: TBC\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows® 10 Home 64 Bit | Windows® 11\r\nProcessor: Intel® Core™ i7-9700K | AMD® Ryzen™ 5 5600X\r\nMemory: 16 GB RAM\r\nGraphics: Nvidia® GeForce™ RTX 2080 Ti (11GB) | AMD® Radeon™ RX 6800 XT (16GB)\r\nSound Card: TBC",
                    Rating=0,
                },
                new Game(){
                    Id=8,
                    Name="Forza Horizon 5",
                    ReleaseDate= new DateTime(2021, 11, 9),
                    Developer="Playground Games",
                    Publisher="Xbox Game Studios",
                    Poster=@"https://cdn.cloudflare.steamstatic.com/steam/apps/1551360/header.jpg?t=1694801571",
                    Description="Your Ultimate Horizon Adventure awaits! Explore the vibrant open world landscapes of Mexico with limitless, fun driving action in the world’s greatest cars. Conquer the rugged Sierra Nueva in the ultimate Horizon Rally experience. Requires Forza Horizon 5 game, expansion sold separately.",
                    SystemRequirements="MINIMUM:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 version 15063.0 or higher\r\nProcessor: Intel i5-4460 or AMD Ryzen 3 1200\r\nMemory: 8 GB RAM\r\nGraphics: NVidia GTX 970 OR AMD RX 470\r\nDirectX: Version 12\r\nNetwork: Broadband Internet connection\r\nStorage: 110 GB available space\r\nRECOMMENDED:\r\nRequires a 64-bit processor and operating system\r\nOS: Windows 10 version 15063.0 or higher\r\nProcessor: Intel i5-8400 or AMD Ryzen 5 1500X\r\nMemory: 16 GB RAM\r\nGraphics: NVidia GTX 1070 OR AMD RX 590\r\nDirectX: Version 12\r\nNetwork: Broadband Internet connection\r\nStorage: 110 GB available space\r\n",
                    Rating=88,
                },
            };
        }
    }
}
