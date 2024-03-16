using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Common;

namespace Api.IBPR.Website.WebAPI.Controllers
{
    public class CoverImage: ControllerBase
    {
        private readonly ICoverImage _coverImageRepository;
        public CoverImage(ICoverImage coverImageRepository) => 
            _coverImageRepository = coverImageRepository;

        [HttpGet("{id}")]
        public async Task<ActionResult<Image>> GetById(int id)
        {
            var result = await _coverImageRepository.GetCoverImage(id);

            if(result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost("SetCoverImage")]
        public async Task<ActionResult> SetCoverImage()
        {
            return Ok("Upload a new Cover Image" );
        }
    }
}