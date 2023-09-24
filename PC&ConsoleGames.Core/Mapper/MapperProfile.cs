using PC_ConsoleGames.Core.DTOs;
using PC_ConsoleGames.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Core.Mapper
{
    public class MapperProfile : AutoMapper.Profile
    {
        public MapperProfile()
        {
            CreateMap<Genre,GenreDTO>()
                .ReverseMap();

            CreateMap<Language,LanguageDTO>().
                ReverseMap();

            CreateMap<Game,GameDTO>().ForMember(gameDTO => gameDTO.Genres, opt => opt.MapFrom(game => game.Genres.Select(a => a._Genre)))
                .ForMember(gameDTO => gameDTO.Languages, opt => opt.MapFrom(game => game.Languages.Select(a => a._Language)))
                .ReverseMap();

            CreateMap<Game, CreateGameDTO>()
                .ForMember(dto => dto.Poster, entity => entity.Ignore())
                .ReverseMap();
        }
    }
}
