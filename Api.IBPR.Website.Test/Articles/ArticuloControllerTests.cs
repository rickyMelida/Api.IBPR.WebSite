using NUnit.Framework;
using Api.IBPR.Website.WebAPI.Controllers;
using Api.IBPR.Website.Domain.Entities; // Ajusta el namespace según tu proyecto
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Test.DataTest;
using System.Text;
using System.Threading.Tasks;

[TestFixture]
public class ArticuloControllerTests
{
    [Test]
    public async Task ShouldReturnItemWhenReadingExistingItem()
    {
        // Arrange
        var articleId = 1;
        string text = "this is a text example ";

        var mockRepository = new Mock<IArticle>();
        mockRepository.Setup(repo => repo.GetArticle(articleId)).ReturnsAsync(ArticleDataExamples.ArticleById(articleId));
        var controller = new ArticleController(mockRepository.Object);

        // Act
        var result = await controller.GetById(articleId);

        // Assert
        Assert.IsInstanceOf<ActionResult<Article>>(result);
        var objectResult = result as ActionResult<Article>;

        Assert.IsNotNull(objectResult.Value);
        var articulo = objectResult.Value as Article;
        Assert.AreEqual(articleId, articulo.Id);
    }
    /*
    [Test]
    public async void ShouldCreateItemWhenValidData()
    {
        // Arrange
        var mockRepositorio = new Mock<IArticle>();
        var controller = new ArticleController(mockRepositorio.Object);

        // Act
        var result = await controller.SetArticle(ArticleDataExamples.ArticleById(1));

        // Assert
        Assert.IsInstanceOf<ActionResult>(result);
        var objectResult = result as ActionResult;

        Assert.IsNotNull(objectResult.Value);
        var articleCreate = objectResult.Value as Article;
        Assert.AreEqual(nuevoArticulo.Titulo, articuloCreado.Titulo);
    }

    [Test]
    public void ActualizarArticulo_DebeRetornarNoContent()
    {
        // Arrange
        var articuloExistente = new Articulo { Id = 1, Titulo = "Articulo existente" };
        var mockRepositorio = new Mock<IArticuloRepository>();
        mockRepositorio.Setup(repo => repo.ActualizarArticulo(articuloExistente)).Verifiable();
        var controlador = new ArticuloController(mockRepositorio.Object);

        // Act
        var resultado = controlador.ActualizarArticulo(articuloExistente.Id, articuloExistente);

        // Assert
        Assert.IsInstanceOf<NoContentResult>(resultado);
        mockRepositorio.Verify(); // Asegura que el método del repositorio fue llamado
    }

    [Test]
    public void EliminarArticulo_DebeRetornarNoContent()
    {
        // Arrange
        var articuloId = 1;
        var mockRepositorio = new Mock<IArticuloRepository>();
        mockRepositorio.Setup(repo => repo.EliminarArticulo(articuloId)).Verifiable();
        var controlador = new ArticuloController(mockRepositorio.Object);

        // Act
        var resultado = controlador.EliminarArticulo(articuloId);

        // Assert
        Assert.IsInstanceOf<NoContentResult>(resultado);
        mockRepositorio.Verify(); // Asegura que el método del repositorio fue llamado
    }*/
}
