using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Interfaces
{
    public interface IArticleServices
    {
        Task<Article> GetArticleById(int id);
        Task<List<BlogArticle>> GetBlogArticles();
        Task<BlogArticle> SetBlogArticle(BlogArticle blogArticle);
    }
}