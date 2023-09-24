using AutoMapper;
using PC_ConsoleGames.Core.DTOs;
using PC_ConsoleGames.Core.Entities;
using PC_ConsoleGames.Core.Helpers;
using PC_ConsoleGames.Core.Interfaces;
using PC_ConsoleGames.Core.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Core.Services
{
    public class GenreService : IGenreService 
    {
        private readonly IRepository<Genre> _genreRepository;
        private readonly IMapper _mapper;

        public GenreService(IRepository<Genre> genreRepository, IMapper mapper)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(GenreDTO genreDTO)
        {
            var genre = _mapper.Map<Genre>(genreDTO);
            await _genreRepository.InsertAsync(genre);
            await _genreRepository.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            if (_genreRepository.GetByIDAsync(id) != null)
            {
                await _genreRepository.DeleteAsync(id);
                await _genreRepository.SaveAsync();
            }
        }

        public async Task<List<GenreDTO>> GetAllAsync()
        {
            var genres = await _genreRepository.GetAsync();
            return _mapper.Map<List<GenreDTO>>(genres);
        }

        public async Task<GenreDTO?> GetByIdAsync(int id)
        {
            var genre = await _genreRepository.GetByIDAsync(id);
            if (genre != null)
            {
                return _mapper.Map<GenreDTO>(genre);
            }
            else
            {
                throw new CustomHttpException(ErrorMessages.GameNotFoundByID, HttpStatusCode.NotFound);
            }
        }

        public async Task UpdateAsync(GenreDTO genreDTO)
        {
            var genre = await _genreRepository.GetByIDAsync(genreDTO.Id);
            if (genre != null)
            {
                await _genreRepository.UpdateAsync(genre);
                await _genreRepository.SaveAsync();
            }
        }
    }
}
