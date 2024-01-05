using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Domain;
using Api.IBPR.Website.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.IBPR.Website.Persistence.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        public DbSet<Article> Article {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Article>(entity=>
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