using AutoMapper;
using PC_ConsoleGames.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Core.Services
{
    public class LanguageService : ILanguage
    {
        //private readonly IRepository<Language> _languageRepository;
        private readonly IMapper _mapper;

        public LanguageService(/*IRepository<Language> languageRepository,*/ IMapper mapper)
        {
            //_languageRepository = languageRepository;
            _mapper = mapper;
        }

    }
}
