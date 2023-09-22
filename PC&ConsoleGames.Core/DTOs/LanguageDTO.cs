using PC_ConsoleGames.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Core.DTOs
{
    public class LanguageDTO
    {
        int Id { get; set; }
        string Name { get; set; } = null;
        bool LanguageInterface { get; set; }
        bool LanguageFullAudio { get; set; }
        bool LanguageSubtitles { get; set; }
    }
}
