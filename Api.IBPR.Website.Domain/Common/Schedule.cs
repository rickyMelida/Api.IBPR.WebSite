namespace Api.IBPR.Website.Domain.Common
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Day { get; set; } = string.Empty;
        public DateTime Hour { get; set; }
    }
}