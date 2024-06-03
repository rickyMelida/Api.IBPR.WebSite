using Api.IBPR.Website.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.IBPR.Website.Persistence.ContextConfiguration
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.ToTable("schedule", "website");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Day).HasColumnName("day");
            builder.Property(e => e.Hour).HasColumnName("hour");
            builder.Property(e => e.Title).HasColumnName("title");
        }
    }
}