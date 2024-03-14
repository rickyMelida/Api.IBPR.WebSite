using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.IBPR.Website.Persistence.ContextConfiguration
{
    public class CoverImageConfiguration: IEntityTypeConfiguration<CoverImages>
    {
        public void Configure(EntityTypeBuilder<CoverImages> builder)
        {
            builder.ToTable("cover_images", "website");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Counseling).HasColumnName("counseling");
            builder.Property(e => e.Main).HasColumnName("main");
            builder.Property(e => e.Prayer).HasColumnName("prayer");
        }
    }
}