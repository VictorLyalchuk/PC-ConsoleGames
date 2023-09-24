using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using PC_ConsoleGames.Core.Services;
using PC_ConsoleGames.Core.Interfaces;
using System;


namespace PC_ConsoleGames.Core
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddScoped<IGameService, GameService>();

            servicesCollection.AddScoped<IGenreService, GenreService>();

            servicesCollection.AddScoped<ILanguageService, LanguageService>();
        }
        public static void AddValidators(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddFluentValidationAutoValidation();

            servicesCollection.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        }

        public static void AddAutoMapper(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
