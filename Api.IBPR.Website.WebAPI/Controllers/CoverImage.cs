using Microsoft.AspNetCore.Mvc;
using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Domain.Exceptions;

namespace Api.IBPR.Website.WebAPI.Controllers
{
    public class CoverImage : ControllerBase
    {
        private readonly ICoverImagesService _coverImagesService;
        public CoverImage(ICoverImagesService coverImagesService) =>
            _coverImagesService = coverImagesService;

        [HttpGet("GetCoverImages")]
        public async Task<IActionResult> GetCoverImages()
        {
            try
            {
                var coverImages = await _coverImagesService.GetCoverImages();

                if (coverImages == null)
                    return NotFound();

                return Ok(coverImages);
            }
            catch (CoverImageException ex)
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