using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PC_ConsoleGames.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Infrastructure.EntitiesConfiguration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            //Set Primary Key
            builder.HasKey(x => x.Id);

            //Set Property configurations
            builder.Property(x => x.Name)
                   .HasMaxLength(180)
                   .IsRequired();

            //Set Relationship configurations
            builder.HasMany(x => x.Games)
                   .WithOne(x => x._Language)
                   .HasForeignKey(x => x.LanguageId);
        }
    }
}
