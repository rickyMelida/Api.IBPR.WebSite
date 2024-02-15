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
        private readonly IUnitOfWork _unitOfWork;

        public ArticleRepository(AppDbContext context, IUnitOfWork unitOfWork) => 
            (_context, _unitOfWork) = (context, unitOfWork);
        

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

        public async Task<List<Article>> GetRecentsArticles(int amount)
        {
            return await _context.Article.Take(amount).OrderByDescending(x => x.CreateAt).ToListAsync();
        }

        public void SetArticle(Article article)
        {
            _context.Article.Add(article);
            _unitOfWork.Save();
        }

        public async Task<Article> UpdateArticle(int id, Article articleModified)
        {
            var article = await GetArticle(id);

            if (article == null)
                return null;

            article.Title = articleModified.Title;
            article.Title = articleModified.Title.Trim();
            article.Author = articleModified.Author;
            article.Text = articleModified.Text;
            article.UrlImage = articleModified.UrlImage;
            article.Verse = articleModified.Verse;

            await _unitOfWork.Save();

            return article;
        }
    }
}
