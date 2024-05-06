using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Interfaces
{
    public interface IActivityServices
    {
        Task<ActivityDetails> GetActivityById(string activityId);
        Task<List<ActivityDetails>> GetActivities();

    }
}