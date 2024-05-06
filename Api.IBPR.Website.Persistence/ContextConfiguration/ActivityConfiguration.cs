
using Api.IBPR.Website.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.IBPR.Website.Persistence.ContextConfiguration
{
    public class ActivityConfiguration: IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("activities", "website");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Name).HasColumnName("name");
            builder.Property(e => e.Description).HasColumnName("description");
            builder.Property(e => e.DateActivity).HasColumnName("_date");
            builder.Property(e => e.Ubication).HasColumnName("ubication");
            builder.Property(e => e.IdImage).HasColumnName("id_image");
        }   
    }
}