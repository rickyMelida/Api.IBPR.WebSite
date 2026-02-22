using Api.IBPR.Website.Application.DTOs;
using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Domain.Entities;
using MediatR;

namespace Api.IBPR.Website.Application.CQRS.Activities.Queries
{
    public class GetAllActivitiesQueryHandler : IRequestHandler<GetAllActivitiesQuery, List<ActivityDto>>
    {
        private readonly IActivityServices _activityServices;

        public GetAllActivitiesQueryHandler(IActivityServices activityServices) =>
            _activityServices = activityServices;

        public Task<List<ActivityDto>> Handle(GetAllActivitiesQuery request, CancellationToken cancellationToken) =>
            _activityServices.GetActivities();
    }
}
