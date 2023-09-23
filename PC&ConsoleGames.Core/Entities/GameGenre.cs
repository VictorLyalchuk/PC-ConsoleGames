using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Infrastructure.Entities
{
    public class GameGenre
    {
        // composed key
        public int GameId { get; set; }
        public int GenreId { get; set; }

        public Game? Game { get; set; }
        public Genre? Genre { get; set; }
    }
}
