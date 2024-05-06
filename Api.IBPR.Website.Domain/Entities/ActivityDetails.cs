namespace Api.IBPR.Website.Domain.Entities
{
    public class ActivityDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateActivity { get; set; }
        public string Site { get; set; }
        public string Direction { get; set; }
    }
}