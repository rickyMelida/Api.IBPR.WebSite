using Microsoft.AspNetCore.Mvc;
using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Domain.Exceptions;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Domain.Request;

namespace Api.IBPR.Website.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoverImageController : ControllerBase
    {
        private readonly ICoverImagesService _coverImagesService;
        public CoverImageController(ICoverImagesService coverImagesService) =>
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

        [HttpPost("SetCoverImages")]
        public async Task<IActionResult> SetCoverImage(CoverImageRequest coverImagesDetails)
        {
            try
            {
                var coverImages = await _coverImagesService.SetCoverImages(coverImagesDetails);

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