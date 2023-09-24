using PC_ConsoleGames.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Core.Interfaces
{
    public interface IGenreService
    {
        Task<List<GenreDTO>> GetAllAsync();
        Task<GenreDTO?> GetByIdAsync(int id);
        Task CreateAsync(GenreDTO genreDTO);
        Task UpdateAsync(GenreDTO genreDTO);
        Task DeleteAsync(int id);
    }
}
