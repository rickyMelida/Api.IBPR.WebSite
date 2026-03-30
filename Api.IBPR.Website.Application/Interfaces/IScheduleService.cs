using System;
using Api.IBPR.Website.Application.DTOs;

namespace Api.IBPR.Website.Application.Interfaces;

public interface IScheduleService
{
	Task<ScheduleDto> CreateSchedule(ScheduleDto scheduleDto);
}
