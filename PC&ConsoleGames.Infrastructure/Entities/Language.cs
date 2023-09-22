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
        int Id { get; set; }
        [Required]
        string Name { get; set; } = null;
        bool LanguageInterface { get; set; }
        bool LanguageFullAudio { get; set; }
        bool LanguageSubtitles { get; set; }
        public IEnumerable<Game> Games { get; set; }

    }
}
