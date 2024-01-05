namespace Api.IBPR.Website.Domain.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public byte[] Text { get; set; }
        public string  Title {get; set;}
        public string UrlImage {get; set;}
        public string Verse { get; set; }
        public DateTime CreateAt { get; set; }
        public int IdComment { get; set; }
    }
}