using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.IBPR.Website.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITag _tagRepository;

        public TagController(ITag tagRepository) => 
            _tagRepository = tagRepository;

        [HttpGet("")]
        public async Task<ActionResult<List<Tag>>> GetAll()
        {
            var result = await _tagRepository.GetTags();
            return Ok(result);
        }
    }
}
