using Api.IBPR.Website.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.IBPR.Website.Persistence.ContextConfiguration
{
    public class VerseConfiguration : IEntityTypeConfiguration<Verse>
    {
        public void Configure(EntityTypeBuilder<Verse> builder)
        {
            builder.ToTable("VERSES", "WEBSITE");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Text).HasColumnName("TEXT");
            builder.Property(e => e.Chapter).HasColumnName("CHAPTER");
            builder.Property(e => e.Versse).HasColumnName("VERSE");
        }
    }
}
