using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using Api.IBPR.Website.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.IBPR.Website.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArticleController : ControllerBase
{
    private readonly IArticle _articleRepository;

    public ArticleController(IArticle articleRepository) =>
        _articleRepository = articleRepository;
    

    [HttpGet("")]
    public async Task<ActionResult<List<Article>>> GetAll()
    {
        var result = await _articleRepository.GetArticles();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Article>> GetById(int id)
    {
        var result = await _articleRepository.GetArticle(id);
        
        if(result == null)
        {
            return NotFound();
        }

        return Ok(result);
    }

    [HttpPost("SetArticle")]
    public async Task<ActionResult> SetArticle(Article article)
    {
        try
        {
            await _articleRepository.SetArticle(article);

            return CreatedAtAction("Created new Article", article);

        }catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<ActionResult> UpdateArticle([FromRoute] int id, Article article)
    {
        var articleModified = await _articleRepository.UpdateArticle(id, article);

        if (articleModified == null)
            return NotFound();

        return Ok(articleModified);
    }
}