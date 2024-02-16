using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Persistence.ContextConfiguration;
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
            public DbSet<Verse> Verse { get; set;}

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.ApplyConfiguration(new ArticleConfiguration());
                modelBuilder.ApplyConfiguration(new TagConfiguration());
                modelBuilder.ApplyConfiguration(new VerseConfiguration());
            }
        }
}