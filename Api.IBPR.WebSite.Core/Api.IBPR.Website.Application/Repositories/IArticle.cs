using Api.IBPR.Website.Core.Domain.Entities;

namespace Api.IBPR.Website.Core.Application.Repositories
{
    public interface IArticle
    {
        Task<Article> GetArticle (int Id);
        Task<List<Article>> GetRecentsArticles();
        Task<List<Article>> GetArticlesByTagId(int Id);
        Task<Article> SetArticle (Article article);
        Task DeleteArticle (Article article);
        Task UpdateArticle (Article article);
    } 
}