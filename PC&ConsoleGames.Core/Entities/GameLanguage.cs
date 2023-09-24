namespace PC_ConsoleGames.Core.Entities
{
    public class GameLanguage
    {
        // composed key
        public int GameId { get; set; }
        public int LanguageId { get; set; }

        public Game? _Game { get; set; }
        public Language? _Language { get; set; }
    }
}
