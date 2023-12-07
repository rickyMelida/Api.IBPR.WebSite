using Api.IBPR.Website.Core.Application.Repositories;
using Api.IBPR.Website.Core.Domain.Entities;
using Api.IBPR.Website.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Persistence.Repositories
{
    public class ArticleRepository : IArticle
    {
        private readonly OracleDbContext Context;

        public ArticleRepository(OracleDbContext context) => 
            Context = context;
        

        public Task DeleteArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public Task<Article> GetArticle(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetArticles(int Id)
        {
            return Context.Articles;
        }

        public Task<List<Article>> GetArticlesByTagId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Article>> GetRecentsArticles()
        {
            throw new NotImplementedException();
        }

        public void SetArticle(Article article)
        {
            Context.Add(article);
        }

        public Task UpdateArticle(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
