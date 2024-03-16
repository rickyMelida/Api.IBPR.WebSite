using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Services
{
    public class ArticleService
    {
        private readonly IArticle _articleRepository;
        public ArticleService(IArticle articleRepository) => 
            _articleRepository = articleRepository;

        public async Task<Article> GetArticleById(int id)
        {
            var articleResult = await _articleRepository.GetArticle(id);
            
            if (articleResult is null)
                return new Article(){};

            return articleResult;
        }
        
    }
}