using Api.IBPR.Website.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.IBPR.Website.Persistence.ContextConfiguration
{
    public class MainVerseConfiguration: IEntityTypeConfiguration<MainVerse>
    {

        public void Configure(EntityTypeBuilder<MainVerse> builder)
        {
            builder.ToTable("main_verses", "website");

            builder.Property(e => e.Id ).HasColumnName("id");
            builder.Property(e => e.Section).HasColumnName("section");
            builder.Property(e => e.IdVerse).HasColumnName("id_verse");
        }
    }
}