using Api.IBPR.Website.Domain.Common;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Persistence.ContextConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Api.IBPR.Website.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Article> Article { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Verse> Verse { get; set; }
        public DbSet<CoverImages> CoverImage { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Sections> Section { get; set; }
        public DbSet<MainVerse> MainVerses { get; set; }
        public DbSet<Activity> Activity{ get; set; }
        public DbSet<Ubication> Ubication { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ArticleConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new VerseConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());
            modelBuilder.ApplyConfiguration(new CoverImageConfiguration());
            modelBuilder.ApplyConfiguration(new SectionConfiguration());
            modelBuilder.ApplyConfiguration(new MainVerseConfiguration());
            modelBuilder.ApplyConfiguration(new ActivityConfiguration());
            modelBuilder.ApplyConfiguration(new UbicationConfiguration());
        }
    }
}