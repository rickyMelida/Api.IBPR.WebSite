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
        public DbSet<Tag> Tag { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Article>(entity=>
            {
                entity.ToTable("ARTICLES", "WEBSITE");
                
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Author).HasColumnName("AUTHOR");
                entity.Property(e => e.Text).HasColumnName("TEXT");
                entity.Property(e => e.Title).HasColumnName("TITLE");
                entity.Property(e => e.IdImage).HasColumnName("ID_IMAGE");
                entity.Property(e => e.IdVerse).HasColumnName("ID_VERSE");
                entity.Property(e => e.CreateAt).HasColumnName("CREATED_AT");
                entity.Property(e => e.IdComment).HasColumnName("ID_COMMENT");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("TAGS", "WEBSITE");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Name).HasColumnName("TAG_NAME");
            });
        }
    }
}