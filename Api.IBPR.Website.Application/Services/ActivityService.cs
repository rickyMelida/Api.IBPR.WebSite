using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Domain.Exceptions;

namespace Api.IBPR.Website.Application.Services
{
    public class ActivityService : IActivityServices
    {
        private readonly IActivity _activityRepository;
        private readonly IUbication _ubicationRepository;

        public ActivityService(IActivity activityRepository, IUbication ubicationRepository) =>
            (_activityRepository, _ubicationRepository) = (activityRepository, ubicationRepository);
        
        public async Task<List<ActivityDetails>> GetActivities()
        {
            var result = (from activity in await _activityRepository.GetActivities()
                         join ubication in await _ubicationRepository.GetUbications()
                         on activity.Ubication equals ubication.Id
                         select new ActivityDetails
                         {
                            Id = activity.Id,
                            Name = activity.Name,
                            Description = activity.Description,
                            DateActivity = activity.DateActivity,
                            Site = ubication.Site,
                            Direction = ubication.Direction,
                         }).ToList<ActivityDetails>();

            if(result.Count == 0)
                throw new ActivityException();

            return result;
        }

        public Task<ActivityDetails> GetActivityById(string activityId)
        {
            throw new NotImplementedException();
        }
    }
}