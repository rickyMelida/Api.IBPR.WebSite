using Api.IBPR.Website.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.IBPR.Website.Persistence.ContextConfiguration
{
    public class SectionConfiguration: IEntityTypeConfiguration<Sections>
    {
        public void Configure(EntityTypeBuilder<Sections> builder)
        {
            builder.ToTable("sections", "website");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Section).HasColumnName("section");
        }   
    }
}