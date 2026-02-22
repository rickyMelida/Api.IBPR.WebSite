using Api.IBPR.Website.Application.DTOs;
using MediatR;

namespace Api.IBPR.Website.Application.CQRS.Activities.Queries
{
    public class GetAllActivitiesQuery : IRequest<List<ActivityDto>>
    {
    }
}
