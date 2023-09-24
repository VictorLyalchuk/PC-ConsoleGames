namespace PC_ConsoleGames.Core.Entities
{
    public class GameGenre
    {
        // composed key
        public int GameId { get; set; }
        public int GenreId { get; set; }

        public Game? _Game { get; set; }
        public Genre? _Genre { get; set; }
    }
}
