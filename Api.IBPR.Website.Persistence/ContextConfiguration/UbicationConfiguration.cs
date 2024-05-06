using Api.IBPR.Website.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.IBPR.Website.Persistence.ContextConfiguration
{
    public class UbicationConfiguration: IEntityTypeConfiguration<Ubication>
    {
        public void Configure(EntityTypeBuilder<Ubication> builder)
        {
                builder.ToTable("ubication", "website");

                builder.Property(e => e.Id).HasColumnName("id");
                builder.Property(e => e.Site).HasColumnName("site");
                builder.Property(e => e.Direction).HasColumnName("direction");
        }
    }
}