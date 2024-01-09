using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Repositories
{
    public interface IArticle
    {
        Task<Article> GetArticle (int Id);
        Task<List<Article>> GetArticles ();
        Task<List<Article>> GetRecentsArticles(int amount);
        Task<List<Article>> GetArticlesByTagId(int Id);
        void SetArticle (Article article);
        Task DeleteArticle (Article article);
        Task UpdateArticle (Article article);
    }
}