using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Infrastructure.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Language> Languages { get; set; }
        public string? Poster { get; set; }
        public string? Description { get; set; }
        public string? SystemRequirements { get; set; }
        public double Rating { get; set; }

    }
}
