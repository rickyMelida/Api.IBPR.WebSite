using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Application.Repositories
{
    public interface IArticle
    {
        Task<Article> GetArticle (int Id);
        IEnumerable<Article> GetArticles (int Id);
        Task<List<Article>> GetRecentsArticles();
        Task<List<Article>> GetArticlesByTagId(int Id);
        void SetArticle (Article article);
        Task DeleteArticle (Article article);
        Task UpdateArticle (Article article);
    }
}