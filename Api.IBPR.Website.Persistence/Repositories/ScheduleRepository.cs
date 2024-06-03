using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Common;
using Api.IBPR.Website.Domain.Exceptions;
using Api.IBPR.Website.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.IBPR.Website.Persistence.Repositories
{
    public class ScheduleRepository : ISchedule
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public ScheduleRepository(AppDbContext context, IUnitOfWork unitOfWork) =>
            (_context, _unitOfWork) = (context, unitOfWork);

        public async Task<Schedule> GetSchedule(int id)
        {
            try
            {

                var schedule = await _context.Schedule.FirstOrDefaultAsync(e => e.Id == id);

                if (schedule == null)
                    return null;

                return schedule;
            }
            catch (Exception)
            {
                throw new ScheduleException();
            }
        }

        public async Task<List<Schedule>> GetSchedules()
        {
            try
            {
                var schedules = await _context.Schedule.ToListAsync();

                if (schedules.Count == 0)
                    return null;

                return schedules;
            }
            catch (Exception)
            {
                throw new ScheduleException();
            }
        }

        public async Task<DefaultResponse> SetSchedule(Schedule schedule)
        {
            try
            {
                await _context.Schedule.AddAsync(schedule);
                await _unitOfWork.Save();

                return new DefaultResponse { Code = 0, Message = "Ok" };
            }
            catch (Exception ex)
            {

                throw new ScheduleException(ex.Message);
            }
        }
    }
}