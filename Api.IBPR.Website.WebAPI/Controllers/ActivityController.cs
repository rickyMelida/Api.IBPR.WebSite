using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.IBPR.Website.WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityServices _activityService;
        public ActivityController(IActivityServices activityServices) =>
            _activityService = activityServices;

        [HttpGet("")]
        public async Task<ActionResult<List<ActivityDetails>>> GetAll()
        {
            var activityDetails = await _activityService.GetActivities();

            if (activityDetails == null)
                return NotFound();

            return Ok(activityDetails);
        }

        [HttpGet("GetActivity/{id}")]
        public async Task<ActionResult<ActivityDetails>> GetById(int id)
        {
            var activityDetails = await _activityService.GetActivityById(id);

            if (activityDetails == null)
                return NotFound();

            return Ok(activityDetails);
        }
    }
}