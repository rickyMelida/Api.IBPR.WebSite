using NUnit.Framework;
using Api.IBPR.Website.Domain.Entities;
using Moq;
using System;
using Api.IBPR.Website.Application.Repositories;
using System.Threading.Tasks;
using Api.IBPR.Website.Application.Services;
using Api.IBPR.Website.Test.DataTest;

[TestFixture]
public class ArticuloControllerTests
{
    [Test]
    public async Task ShouldReturnItemWhenReadingExistingItem()
    {
        Article expectedArticle = ArticleDataExamples.ArticleById(1);

        var articleRepositoryMock = new Mock<IArticle>();
        var articleService = new ArticleService(articleRepositoryMock.Object);

        articleRepositoryMock.Setup(a => a.GetArticle(1)).ReturnsAsync(expectedArticle);

        var currentArticle = await articleService.GetArticleById(1);

        Assert.AreEqual(expectedArticle, currentArticle);

    }

    
}
