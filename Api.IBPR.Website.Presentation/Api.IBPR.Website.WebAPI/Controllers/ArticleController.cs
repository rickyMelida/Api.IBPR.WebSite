using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Application.Features.ArticleFeatures.CreateArticle;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.IBPR.Website.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ArticleController(IMediator mediator)
        {
            _mediator = mediator;
        }
        private static readonly string[] Types = new[]
        {
            "Life", "Salms", "Jesus", "Gospel", "Theologic", "Revelation", "Proverbs", "God", "Freedom"
        };

        [HttpGet(Name = "GetTypes")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Types[Random.Shared.Next(Types.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public async Task<ActionResult<CreateArticleResponse>> Create(CreateArticleRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _mediator.Send(request, cancellationToken);
                return Ok(response);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}