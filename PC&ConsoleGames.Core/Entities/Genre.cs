using System.ComponentModel.DataAnnotations;

namespace PC_ConsoleGames.Core.Entities
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null;
        public IEnumerable<GameGenre> Games { get; set; }

    }
}
