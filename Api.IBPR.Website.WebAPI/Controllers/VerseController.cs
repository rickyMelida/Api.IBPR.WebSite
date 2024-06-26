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

        [HttpGet("GetHeaderVerses")]
        public async Task<IActionResult> GetHeaderVerse()
        {
            try
            {
                var verses = await _verseService.GetMainVerses();

                if(verses == null)
                    return NotFound();

                return Ok(verses);
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

        [HttpPost("SetHeaderVerse")]
        public async Task<IActionResult> SetHeaderVerse(HeaderVerses headerVerses)
        {
            try 
            {
                var verses = await _verseService.SetMainVerses(headerVerses);

                if(verses.Code == 1) 
                    return BadRequest(verses.Message);

                return Ok(verses);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}