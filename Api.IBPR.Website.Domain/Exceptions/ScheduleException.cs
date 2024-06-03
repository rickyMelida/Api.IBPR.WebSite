namespace Api.IBPR.Website.Domain.Exceptions
{
    public class ScheduleException: Exception
    {
        public ScheduleException():base("No existe ninguna fecha establecida.") {}
        public ScheduleException(string message):base(message) {}
        
    }
}