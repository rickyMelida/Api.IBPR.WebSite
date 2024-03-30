using Api.IBPR.Website.Domain.Common;

namespace Api.IBPR.Website.Domain.Entities
{
    public class BlogArticle: Article
    {
        public List<Image> images {get; set;} 
        public List<Verse> verses {get; set;}
        public List<Comment> comments {get; set;}
    }
}