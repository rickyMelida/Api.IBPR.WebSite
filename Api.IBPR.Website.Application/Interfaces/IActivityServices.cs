using Api.IBPR.Website.Application.DTOs;
using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Interfaces
{
    public interface IActivityServices
    {
        Task<ActivityDto> GetActivityById(int activityId);
        Task<List<ActivityDto>> GetActivities();
		Task<ActivityDto> CreateActivity(ActivityDto activityDetails);

    }
}