using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Interfaces
{
    public interface IActivityServices
    {
        Task<ActivityDetails> GetActivityById(int activityId);
        Task<List<ActivityDetails>> GetActivities();

    }
}