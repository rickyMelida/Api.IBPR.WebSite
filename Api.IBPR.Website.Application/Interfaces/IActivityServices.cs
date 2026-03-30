using Api.IBPR.Website.Application.DTOs;

namespace Api.IBPR.Website.Application.Interfaces
{
    public interface IActivityService
    {
        Task<ActivityDto> GetActivityById(int activityId);
        Task<List<ActivityDto>> GetActivities();
		Task<ActivityDto> CreateActivity(ActivityDto activityDetails);

    }
}