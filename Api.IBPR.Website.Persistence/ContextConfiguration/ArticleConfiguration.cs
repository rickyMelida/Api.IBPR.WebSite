using Api.IBPR.Website.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.IBPR.Website.Persistence.ContextConfiguration
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("ARTICLES", "WEBSITE");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Author).HasColumnName("AUTHOR");
            builder.Property(e => e.Text).HasColumnName("TEXT");
            builder.Property(e => e.Title).HasColumnName("TITLE");
            builder.Property(e => e.IdImage).HasColumnName("ID_IMAGE");
            builder.Property(e => e.IdVerse).HasColumnName("ID_VERSE");
            builder.Property(e => e.CreateAt).HasColumnName("CREATED_AT");
            builder.Property(e => e.IdComment).HasColumnName("ID_COMMENT");
        }
    }

}
