using Api.IBPR.Website.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.IBPR.Website.Persistence.ContextConfiguration
{
    public class VerseConfiguration : IEntityTypeConfiguration<Verse>
    {
        public void Configure(EntityTypeBuilder<Verse> builder)
        {
            builder.ToTable("verses", "website");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Text).HasColumnName("text");
            builder.Property(e => e.Chapter).HasColumnName("chapter");
            builder.Property(e => e.Versse).HasColumnName("verse");
        }
    }
}
