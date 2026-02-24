using Api.IBPR.Website.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.IBPR.Website.Persistence.ContextConfiguration
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.ToTable("schedule", "ibpr");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Day).HasColumnName("day").HasMaxLength(10).IsRequired(false);
            builder.Property(e => e.Hour).HasColumnName("hour").IsRequired(false);
            builder.Property(e => e.Title).HasColumnName("title").HasMaxLength(50).IsRequired(false);
        }
    }
}