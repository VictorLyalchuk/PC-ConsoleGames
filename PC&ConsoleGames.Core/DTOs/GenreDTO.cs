﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Core.DTOs
{
    public class GenreDTO
    {
        int Id { get; set; }
        string Name { get; set; } = null;
    }
}
