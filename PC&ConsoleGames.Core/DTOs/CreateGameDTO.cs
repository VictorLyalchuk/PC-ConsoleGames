using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Core.DTOs
{
    public class CreateGameDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public IFormFile Poster { get; set; }
        public string Description { get; set; }
        public string SystemRequiements { get; set; }
        public double Raiting { get; set; }
    }
}
