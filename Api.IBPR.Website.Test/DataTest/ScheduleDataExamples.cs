using Api.IBPR.Website.Domain.Common;

namespace Api.IBPR.Website.Test.DataTest
{
    public static class ScheduleDataExamples
    {
        public static Schedule GetSchedule() 
        {
            return new Schedule()
            {
                Id = 1,
                Day = "Sabado",
                Hour = "19:00",
                Title = "Aniversario de la Iglesia"
            };
        }
    }
}