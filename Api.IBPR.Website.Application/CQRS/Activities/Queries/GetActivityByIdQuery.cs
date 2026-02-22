using Api.IBPR.Website.Application.DTOs;
using MediatR;

namespace Api.IBPR.Website.Application.CQRS.Activities.Queries
{
    public class GetActivityByIdQuery : IRequest<ActivityDto>
    {
        public int ActivityId { get; set; }
        
        public GetActivityByIdQuery(int activityId)
        {
            ActivityId = activityId;
        }
    }
}
