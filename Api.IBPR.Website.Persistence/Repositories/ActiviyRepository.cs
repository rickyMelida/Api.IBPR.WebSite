using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.IBPR.Website.Persistence.Repositories
{
    public class ActiviyRepository : IActivity
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public ActiviyRepository(AppDbContext context, IUnitOfWork unitOfWork) =>
        (_context, _unitOfWork) = (context, unitOfWork);

        public async Task<List<Activity>> GetActivities()
        {
            return await _context.Activity.ToListAsync();
        }

        public async Task<Activity> GetActivity(int activityId)
        {
            return await _context.Activity.FirstAsync(x => x.Id == activityId);
        }

        public async Task<List<Activity>> GetLastActivity(int amount)
        {
            return await _context.Activity
                         .OrderByDescending(p => p.DateActivity)
                         .Take(amount)
                         .ToListAsync();
        }

        public async Task<Activity> SetActivity(Activity activity)
        {
            await _context.Activity.AddAsync(activity);
            await _unitOfWork.Save();
            
            return activity;
        }
    }
}