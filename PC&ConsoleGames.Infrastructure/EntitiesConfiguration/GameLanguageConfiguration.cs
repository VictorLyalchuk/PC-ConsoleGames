using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PC_ConsoleGames.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Infrastructure.EntitiesConfiguration
{
    public class GameLanguageConfiguration : IEntityTypeConfiguration<GameLanguage>
    {
        public void Configure(EntityTypeBuilder<GameLanguage> builder)
        {
            //Set Primary Key
            builder.HasKey(m => new { m.GameId, m.LanguageId });
        }
    }
}
