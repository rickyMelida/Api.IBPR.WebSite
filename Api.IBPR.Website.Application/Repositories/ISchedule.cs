using Api.IBPR.Website.Domain.Common;

namespace Api.IBPR.Website.Application.Repositories
{
    public interface IScheduleRepository
    {
        Task<List<Schedule>> GetSchedules();
        Task<Schedule> GetSchedule(int id);
        Task<DefaultResponse> SetSchedule(Schedule schedule);
    }
}