namespace Api.IBPR.Website.Core.Domain.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int UbicationId { get; set; }
        public int IdImage { get; set; }
    }
}