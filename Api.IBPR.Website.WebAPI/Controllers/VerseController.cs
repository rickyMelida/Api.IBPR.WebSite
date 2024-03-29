using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Api.IBPR.Website.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VerseController : ControllerBase
    {
        private readonly IVerseServices _verseService;

        public VerseController(IVerseServices verseServices) =>
            _verseService = verseServices;

        [HttpGet("GetHeaderVerse")]
        public async Task<IActionResult> GetHeaderVerse()
        {
            try
            {
                var result = await _verseService.GetMainVerses();

                if(result == null)
                    return NotFound();

                return Ok(result);
            }
            catch(VersesExceptions ex)
            {
                return NotFound(ex.Message);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}