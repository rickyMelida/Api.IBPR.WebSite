using Api.IBPR.Website.Application.DTOs;
using Api.IBPR.Website.Application.Interfaces;
using MediatR;

namespace Api.IBPR.Website.Application.CQRS.Activities.Commands
{
    public class CreateActivityCommandHandler : IRequestHandler<CreateActivityCommand, ActivityDto>
    {
        private readonly IActivityService _activityService;

        public CreateActivityCommandHandler(IActivityService activityService) =>
            _activityService = activityService;

        public Task<ActivityDto> Handle(CreateActivityCommand request, CancellationToken cancellationToken) =>
            _activityService.CreateActivity(request.ActivityDto);
    }
}
