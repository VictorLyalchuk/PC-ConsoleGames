using AutoMapper;
using PC_ConsoleGames.Core.DTOs;
using PC_ConsoleGames.Core.Interfaces;
using PC_ConsoleGames.Core.Specification;
using PC_ConsoleGames.Core.Entities;
using PC_ConsoleGames.Core.Helpers;
using System.Net;

namespace PC_ConsoleGames.Core.Services
{
    public class GameService : IGameService 
    {
        private readonly IRepository<Game> _gameRepository;
        private readonly IRepository<GameGenre> _gameGenreRepository;
        private readonly IRepository<GameLanguage> _gameLanguageRepository;
        private readonly IMapper _mapper;

        public GameService(IRepository<Game> gameRepository, IRepository<GameGenre> gameGenreRepository, IRepository<GameLanguage> gameLanguageRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _gameGenreRepository = gameGenreRepository;
            _gameLanguageRepository = gameLanguageRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(CreateGameDTO createGameDTO)
        {
            var game = _mapper.Map<Game>(createGameDTO);
            await _gameRepository.InsertAsync(game);
            await _gameRepository.SaveAsync();
            if (createGameDTO.GenreID != null)
            {
                foreach (var genreid in createGameDTO.GenreID)
                {
                    await _gameGenreRepository.InsertAsync(
                    new GameGenre()
                    {
                        GenreId = genreid,
                        GameId = game.Id
                    });
                    await _gameGenreRepository.SaveAsync();
                }
                foreach (var languageid in createGameDTO.LanguageID)
                {
                    await _gameLanguageRepository.InsertAsync(
                        new GameLanguage
                        {
                            LanguageId = languageid,
                            GameId = game.Id
                        });
                    await _gameLanguageRepository.SaveAsync();
                }
            }
        }

        public async Task DeleteAsync(int id)
        {
            if (_gameRepository.GetByIDAsync(id) != null)
            {
                await _gameRepository.DeleteAsync(id);
                await _gameRepository.SaveAsync();
            }
        }

        public async Task<List<GameDTO>> GetAllAsync()
        {
            var games = await _gameRepository.GetListBySpec(new GamesSpecifications.OrderByAllByID());
            return _mapper.Map<List<GameDTO>>(games);
        }

        public async Task<GameDTO?> GetByIdAsync(int id)
        {
            var game = await _gameRepository.GetItemBySpec(new GamesSpecifications.ByID(id));
            if (game != null)
            {
                return _mapper.Map<GameDTO>(game);
            }
            else
            {
                throw new CustomHttpException(ErrorMessages.GameNotFoundByID, HttpStatusCode.NotFound);
            }
        }

        public async Task UpdateAsync(GameDTO gameDTO)
        {
            var game = await _gameRepository.GetByIDAsync(gameDTO.Id);
            if (game != null)
            {
                await _gameGenreRepository.DeleteAsync(game.Id);
                foreach (var genre in gameDTO.Genres)
                {
                    await _gameGenreRepository.InsertAsync(
                        new GameGenre
                        {
                            GenreId = genre.Id,
                            GameId = game.Id
                        });
                    await _gameGenreRepository.SaveAsync();
                }
                await _gameLanguageRepository.DeleteAsync(game.Id);
                foreach (var language in gameDTO.Languages)
                {
                    await _gameLanguageRepository.InsertAsync(
                        new GameLanguage
                        {
                            LanguageId = language.Id,
                            GameId = game.Id
                        });
                    await _gameLanguageRepository.SaveAsync();
                }

                await _gameRepository.UpdateAsync(game);
                await _gameRepository.SaveAsync();
            }
        }
    }
}
