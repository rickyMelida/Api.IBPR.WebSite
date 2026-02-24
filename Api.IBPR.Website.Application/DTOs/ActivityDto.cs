namespace Api.IBPR.Website.Application.DTOs
{
	public class ActivityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public int Schedule { get; set; }
        public int Ubication { get; set; }
        public int Image { get; set; }
    }
}