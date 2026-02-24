namespace Api.IBPR.Website.Application.DTOs
{
	public class ImageDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public byte[] Picture { get; set; } = Array.Empty<byte>();
	}
}