namespace Api.IBPR.Website.Domain.Common
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public byte[] Picture {get; set;} = Array.Empty<byte>();
    }
}