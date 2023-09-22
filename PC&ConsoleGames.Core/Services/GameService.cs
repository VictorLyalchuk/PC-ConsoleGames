using AutoMapper;
using PC_ConsoleGames.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Core.Services
{
    public class GameService : IGame 
    {
        //private readonly IRepository<Game> _gameRepository;
        private readonly IMapper _mapper;

        public GameService(/*IRepository<Game> gameRepository,*/ IMapper mapper)
        {
            //_gameRepository = gameRepository;
            _mapper = mapper;
        }
    }
}
