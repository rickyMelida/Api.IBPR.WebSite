using Api.IBPR.Website.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Infrastructure.Persistence.Context
{
    public class OracleDbContext: DbContext
    {
        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options)
        { }

        public DbSet<Article>  Articles { get; set; }
        public DbSet<Values> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Article>(entity =>
            {
                entity.ToTable("ARTICLES", "TARJETA");
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Author).HasColumnName("AUTHOR");
                entity.Property(e => e.Text).HasColumnName("TEXT");
                entity.Property(e => e.Title).HasColumnName("TITLE");
                entity.Property(e => e.UrlImage).HasColumnName("URL_IMAGE");
                entity.Property(e => e.Verse).HasColumnName("VERSE");
                entity.Property(e => e.CreateAt).HasColumnName("CREATED_AT");
                entity.Property(e => e.IdComment).HasColumnName("ID_COMMENT");
            });
        }

    }
}
