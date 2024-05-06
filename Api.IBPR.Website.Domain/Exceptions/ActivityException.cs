namespace Api.IBPR.Website.Domain.Exceptions
{
    public class ActivityException : Exception
    {
        public ActivityException() : base("No hay actividades que mostrar") { }
        public ActivityException(string message) : base(message) { }

    }
}