namespace Api.IBPR.Website.Domain.Exceptions
{
    public class ImageException: Exception
    {
        public ImageException(): base("No existe imagen.") { }
        public ImageException(string message): base(message) { }
    }
}