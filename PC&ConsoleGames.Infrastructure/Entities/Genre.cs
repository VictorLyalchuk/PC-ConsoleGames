using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Infrastructure.Entities
{
    public class Genre
    {
        [Key]
        int Id { get; set; }
        [Required]
        string Name { get; set; } = null;
        public IEnumerable<Game> Games { get; set; }

    }
}
