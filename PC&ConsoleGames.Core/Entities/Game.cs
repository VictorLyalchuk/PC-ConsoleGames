using System.Runtime.Serialization;

namespace PC_ConsoleGames.Core.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public string? Poster { get; set; }
        public string? Description { get; set; }
        public string? SystemRequirements { get; set; }
        public double Rating { get; set; }
        public IEnumerable<GameGenre> Genres { get; set; }
        public IEnumerable<GameLanguage> Languages { get; set; }
    }
}
