using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Domain.Exceptions;

namespace Api.IBPR.Website.Application.Services
{
    public class ArticleService: IArticleServices
    {
        private readonly IArticle _articleRepository;
        public ArticleService(IArticle articleRepository) => 
            _articleRepository = articleRepository;

        public async Task<Article> GetArticleById(int id)
        {
            var articleResult = await _articleRepository.GetArticle(id);
            
            if (articleResult is null)
                throw new ArticleException();

            return articleResult;
        }

        public Task<List<BlogArticle>> GetBlogArticles()
        {
            throw new NotImplementedException();
        }

        public async Task<BlogArticle> SetBlogArticle(BlogArticle blogArticle)
        {
            //Article newArticle = blogArticle;

            //await _articleRepository.SetArticle(newArticle);

            throw new NotImplementedException();
        }


        
    }
}