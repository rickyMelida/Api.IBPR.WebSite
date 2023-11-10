namespace Api.IBPR.Website.Core.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime CreateAt { get; set; }
    }
}