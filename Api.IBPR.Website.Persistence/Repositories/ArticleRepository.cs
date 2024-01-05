using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Api.IBPR.Website.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Persistence.Repositories
{
    public class ArticleRepository : IArticle
    {
        private readonly AppDbContext _context;

        public ArticleRepository(AppDbContext context) => 
            _context = context;
        

        public Task DeleteArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public async Task<Article> GetArticle(int id)
        {
            return await _context.Article.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Article>> GetArticles()
        {
            return await _context.Article.ToListAsync();
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
            throw new NotImplementedException();
        }

        public Task UpdateArticle(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
