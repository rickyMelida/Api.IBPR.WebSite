using Api.IBPR.Website.Application.DTOs;
using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Domain.Entities;
using MediatR;

namespace Api.IBPR.Website.Application.CQRS.Activities.Queries
{
    public class GetActivityByIdQueryHandler : IRequestHandler<GetActivityByIdQuery, ActivityDto>
    {
        private readonly IActivityServices _activityServices;

        public GetActivityByIdQueryHandler(IActivityServices activityServices) =>
            _activityServices = activityServices;

        public Task<ActivityDto> Handle(GetActivityByIdQuery request, CancellationToken cancellationToken) =>
            _activityServices.GetActivityById(request.ActivityId);
    }
}
