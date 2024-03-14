using Api.IBPR.Website.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.IBPR.Website.Persistence.ContextConfiguration
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("articles", "website");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Author).HasColumnName("author");
            builder.Property(e => e.Text).HasColumnName("text");
            builder.Property(e => e.Title).HasColumnName("title");
            builder.Property(e => e.IdImage).HasColumnName("id_image");
            builder.Property(e => e.IdVerse).HasColumnName("id_verse");
            builder.Property(e => e.CreateAt).HasColumnName("created_at");
            builder.Property(e => e.IdComment).HasColumnName("id_comment");
        }
    }

}
