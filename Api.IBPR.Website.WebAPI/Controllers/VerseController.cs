using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Domain.Entities;
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

        [HttpGet("")]
        public async Task<List<HeaderVerses>> GetHeaderVerse()
        {
            try
            {
                var result = await _verseService.GetMainVerses();

                if(result == null)
                    return new List<HeaderVerses> {};

                return result.ToList();
            }
            catch
            {
                return new List<HeaderVerses> {};
            }
        }
    }
}