using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Repositories
{
    public interface IActivity
    { 
        Task<List<Activity>> GetActivities();
        Task<Activity> GetActivity(int activityId);
        Task<List<Activity>> GetLastActivity(int amount);
        Task<Activity> SetActivity(Activity activity);
    }
}