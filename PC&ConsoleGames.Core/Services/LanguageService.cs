using AutoMapper;
using PC_ConsoleGames.Core.DTOs;
using PC_ConsoleGames.Core.Entities;
using PC_ConsoleGames.Core.Helpers;
using PC_ConsoleGames.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Core.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly IRepository<Language> _languageRepository;
        private readonly IMapper _mapper;

        public LanguageService(IRepository<Language> languageRepository, IMapper mapper)
        {
            _languageRepository = languageRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(LanguageDTO languageDTO)
        {
            var language = _mapper.Map<Language>(languageDTO);
            await _languageRepository.InsertAsync(language);
            await _languageRepository.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            if (_languageRepository.GetByIDAsync(id) != null)
            {
                await _languageRepository.DeleteAsync(id);
                await _languageRepository.SaveAsync();
            }
        }

        public async Task<List<LanguageDTO>> GetAllAsync()
        {
            var languages = await _languageRepository.GetAsync();
            return _mapper.Map<List<LanguageDTO>>(languages);
        }

        public async Task<LanguageDTO?> GetByIdAsync(int id)
        {
            var language = await _languageRepository.GetByIDAsync(id);
            if (language != null)
            {
                return _mapper.Map<LanguageDTO>(language);
            }
            else
            {
                throw new CustomHttpException(ErrorMessages.GameNotFoundByID, HttpStatusCode.NotFound);
            }
        }

        public async Task UpdateAsync(LanguageDTO languageDTO)
        {
            var language = await _languageRepository.GetByIDAsync(languageDTO.Id);
            if (language != null)
            {
                await _languageRepository.UpdateAsync(language);
                await _languageRepository.SaveAsync();
            }
        }
    }
}
