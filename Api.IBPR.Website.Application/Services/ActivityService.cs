using Api.IBPR.Website.Application.DTOs;
using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Domain.Exceptions;

namespace Api.IBPR.Website.Application.Services
{
	public class ActivityService : IActivityService
	{
		private readonly IActivityRepository _activityRepository;

		public ActivityService(IActivityRepository activityRepository) =>
			_activityRepository = activityRepository;
		public async Task<ActivityDto> CreateActivity(ActivityDto activityDto)
		{
			try
			{
				var activity = new Activity
				{
					Name = activityDto.Name,
					Description = activityDto.Description,
					Schedule = activityDto.Schedule,
					Ubication = activityDto.Ubication,
					Image = activityDto.Image
				};

				var createdActivity = await _activityRepository.SetActivity(activity);

				activityDto.Id = createdActivity.Id;
				return activityDto;
			}
			catch (Exception ex)
			{
				throw new ActivityException("Error al crear la actividad");
			}
		}

		public async Task<List<ActivityDto>> GetActivities()
		{
			var result = await _activityRepository.GetActivities();

			if (result.Count == 0)
				throw new ActivityException("No se encontraron actividades");

			return new List<ActivityDto>(from activity in result
										 select new ActivityDto
										 {
											 Id = activity.Id,
											 Name = activity.Name,
											 Description = activity.Description,
											 Schedule = activity.Schedule,
											 Ubication = activity.Ubication,
											 Image = activity.Image
										 }).ToList();

		}

		public async Task<ActivityDto> GetActivityById(int activityId)
		{
			var result = (from activity in await _activityRepository.GetActivities()
						  select new ActivityDto
						  {
							  Id = activity.Id,
							  Name = activity.Name,
							  Description = activity.Description,
							  Schedule = activity.Schedule,
							  Ubication = activity.Ubication,
							  Image = activity.Image
						  }).FirstOrDefault(e => e.Id == activityId);

			if (result == null)
				throw new ActivityException("No se encontró la actividad");

			return result;
		}
	}
}