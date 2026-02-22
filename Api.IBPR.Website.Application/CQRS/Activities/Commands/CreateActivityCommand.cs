using Api.IBPR.Website.Application.DTOs;
using MediatR;

namespace Api.IBPR.Website.Application.CQRS.Activities.Commands
{
    public class CreateActivityCommand : IRequest<ActivityDto>
    {
        public CreateActivityCommand(ActivityDto activityDto) => ActivityDto = activityDto;

        public ActivityDto ActivityDto { get; }
    }
}
