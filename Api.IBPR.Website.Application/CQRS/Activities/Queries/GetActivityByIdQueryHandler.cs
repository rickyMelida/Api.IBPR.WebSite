using Api.IBPR.Website.Application.DTOs;
using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Domain.Entities;
using MediatR;

namespace Api.IBPR.Website.Application.CQRS.Activities.Queries
{
    public class GetActivityByIdQueryHandler : IRequestHandler<GetActivityByIdQuery, ActivityDto>
    {
        private readonly IActivityService _activityService;

        public GetActivityByIdQueryHandler(IActivityService activityService) =>
            _activityService = activityService;

        public Task<ActivityDto> Handle(GetActivityByIdQuery request, CancellationToken cancellationToken) =>
            _activityService.GetActivityById(request.ActivityId);
    }
}
