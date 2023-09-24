using PC_ConsoleGames.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Core.Interfaces
{
    public interface ILanguageService
    {
        Task<List<LanguageDTO>> GetAllAsync();
        Task<LanguageDTO?> GetByIdAsync(int id);
        Task CreateAsync(LanguageDTO languageDTO);
        Task UpdateAsync(LanguageDTO languageDTO);
        Task DeleteAsync(int id);
    }
}
