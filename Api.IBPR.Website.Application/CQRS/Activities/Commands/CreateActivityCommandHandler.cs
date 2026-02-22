using Api.IBPR.Website.Application.DTOs;
using Api.IBPR.Website.Application.Interfaces;
using MediatR;

namespace Api.IBPR.Website.Application.CQRS.Activities.Commands
{
    public class CreateActivityCommandHandler : IRequestHandler<CreateActivityCommand, ActivityDto>
    {
        private readonly IActivityServices _activityServices;

        public CreateActivityCommandHandler(IActivityServices activityServices) =>
            _activityServices = activityServices;

        public Task<ActivityDto> Handle(CreateActivityCommand request, CancellationToken cancellationToken) =>
            _activityServices.CreateActivity(request.ActivityDto);
    }
}
