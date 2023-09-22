using AutoMapper;
using PC_ConsoleGames.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Core.Services
{
    public class GenreService : IGenre 
    {
        //private readonly IRepository<Genre> _genreRepository;
        private readonly IMapper _mapper;

        public GenreService(/*IRepository<Genre> genreRepository,*/ IMapper mapper)
        {
            //_genreRepository = genreRepository;
            _mapper = mapper;
        }
    }
}
