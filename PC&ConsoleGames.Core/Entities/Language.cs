using System.ComponentModel.DataAnnotations;

namespace PC_ConsoleGames.Core.Entities
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null;
        public IEnumerable<GameLanguage> Games { get; set; }

    }
}
