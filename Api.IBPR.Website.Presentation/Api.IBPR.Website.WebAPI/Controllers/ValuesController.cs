using Api.IBPR.Website.Core.Application.Repositories;
using Api.IBPR.Website.Infrastructure.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.IBPR.Website.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly IValues _valuesRepository;

        public ValuesController(IValues valuesRepository)
        {
            _valuesRepository = valuesRepository;
        }

        [HttpGet(Name = "GetValues")]
        public async Task<IActionResult> Get()
        {
            var values = await _valuesRepository.GetAll();
            return Ok(values);
        }
    }
}
