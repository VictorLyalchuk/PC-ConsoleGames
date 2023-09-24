using PC_ConsoleGames.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Core.Interfaces
{
    public interface IGameService
    {
        Task<List<GameDTO>> GetAllAsync();
        Task<GameDTO?> GetByIdAsync(int id);
        Task CreateAsync(CreateGameDTO createGameDTO);
        Task UpdateAsync(GameDTO gameDTO);
        Task DeleteAsync(int id);
    }
}
