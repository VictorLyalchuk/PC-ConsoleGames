using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PC_ConsoleGames.Core.Entities;
using PC_ConsoleGames.Infrastructure.EntitiesConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Infrastructure.Data
{
    public class GameDBContext : IdentityDbContext<AppUser>
    {
        public GameDBContext(DbContextOptions<GameDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new GameConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new GameGenreConfiguration());
            modelBuilder.ApplyConfiguration(new GameLanguageConfiguration());
            modelBuilder.Entity<Game>().HasData(SeedData.GetGames());
            modelBuilder.Entity<Genre>().HasData(SeedData.GetGenres());
            modelBuilder.Entity<Language>().HasData(SeedData.GetLanguages());
            modelBuilder.Entity<GameGenre>().HasData(SeedData.GetGamesGenres());
            modelBuilder.Entity<GameLanguage>().HasData(SeedData.GetGamesLanguages());

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<GameGenre> GamesGenres { get; set; }
        public DbSet<GameLanguage> GamesLanguages { get; set; }
    }
}
