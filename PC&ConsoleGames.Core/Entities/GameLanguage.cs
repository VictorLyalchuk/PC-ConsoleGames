using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Infrastructure.Entities
{
    public class GameLanguage
    {
        // composed key
        public int GameId { get; set; }
        public int LanguageId { get; set; }

        public Game? Game { get; set; }
        public Language? Language { get; set; }
    }
}
