using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Infrastructure.Entities
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null;
        public bool LanguageInterface { get; set; }
        public bool LanguageFullAudio { get; set; }
        public bool LanguageSubtitles { get; set; }
        public IEnumerable<Game> Games { get; set; }

    }
}
