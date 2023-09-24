using Microsoft.AspNetCore.Http;
using PC_ConsoleGames.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Core.DTOs
{
    public class GameDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public string? ImagePath { get; set; }
        public string Description { get; set; }
        public string SystemRequirements { get; set; }
        public double Rating { get; set; }
        public IEnumerable<GenreDTO> Genres { get; set; }
        public IEnumerable<LanguageDTO> Languages { get; set; }
    }
}
