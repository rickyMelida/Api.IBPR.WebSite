using Api.IBPR.Website.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.IBPR.Website.Persistence.ContextConfiguration
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("TAGS", "WEBSITE");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Name).HasColumnName("TAG_NAME");
        }
    }
}
