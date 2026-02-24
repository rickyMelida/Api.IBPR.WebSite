using Api.IBPR.Website.Application.CQRS.Activities.Commands;
using Api.IBPR.Website.Application.CQRS.Activities.Queries;
using Api.IBPR.Website.Application.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.IBPR.Website.WebAPI.Controllers
{

    [ApiController]
    [Route("api/activities")]
    public class ActivityController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ActivityController(IMediator mediator) =>
            _mediator = mediator;

        [HttpGet("get-all")]
        public async Task<ActionResult<List<ActivityDto>>> GetAll()
        {
            var activityDetails = await _mediator.Send(new GetAllActivitiesQuery());

            if (activityDetails == null)
                return NotFound();

            return Ok(activityDetails);
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<ActionResult<ActivityDto>> GetById(int id)
        {
            var activityDetails = await _mediator.Send(new GetActivityByIdQuery(id));

            if (activityDetails == null)
                return NotFound();

            return Ok(activityDetails);
        }

         [HttpPost("create")]
        public async Task<ActionResult<ActivityDto>> CreateActivity(ActivityDto activityDetails)
        {
            var createdActivity = await _mediator.Send(new CreateActivityCommand(activityDetails));

			if (createdActivity == null)
				return BadRequest();

			return Ok(createdActivity);
		}
    }
}