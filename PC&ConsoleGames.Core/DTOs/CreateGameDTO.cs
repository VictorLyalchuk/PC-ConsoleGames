namespace PC_ConsoleGames.Core.DTOs
{
    public class CreateGameDTO
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
        public IEnumerable<int> GenreID { get; set; }
        public IEnumerable<int> LanguageID { get; set; }
    }
}
