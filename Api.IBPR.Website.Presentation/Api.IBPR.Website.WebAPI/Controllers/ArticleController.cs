using Api.IBPR.Website.Core.Domain.Entities;
using Api.IBPR.Website.Persistence.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.IBPR.Website.WebAPI.Controllers
{
    [ApiController]
    [Route("[article]")]
    public class ArticleController : ControllerBase
    {
        private readonly OracleDbContext _oracledbContext;

        public ArticleController(OracleDbContext oracledbContext)
        {
            _oracledbContext = oracledbContext;
        }



        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<Article>> GetArticles()
        {
            var result = await _oracledbContext.Articles.ToListAsync();

            return result;
        }
    }
}
