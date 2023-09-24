using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PC_ConsoleGames.Core.Entities;


namespace PC_ConsoleGames.Infrastructure.EntitiesConfiguration
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            //Set Primary Key
            builder.HasKey(x => x.Id);

            //Set Property configurations
            builder.Property(x => x.Name)
                   .HasMaxLength(180)
                   .IsRequired();

            builder.Property(x => x.Description)
                   .HasMaxLength(1024);

            //Set Relationship configurations
            builder.HasMany(x => x.Genres)
                   .WithOne(x => x._Game)
                   .HasForeignKey(x => x.GameId);
        }
    }
}
