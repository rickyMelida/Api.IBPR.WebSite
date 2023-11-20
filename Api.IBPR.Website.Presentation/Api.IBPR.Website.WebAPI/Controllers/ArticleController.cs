using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.IBPR.Website.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : ControllerBase
    {
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
    }
}