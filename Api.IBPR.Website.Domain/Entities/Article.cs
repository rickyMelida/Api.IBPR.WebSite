using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Domain.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public string  Title {get; set;}
        public int UrlImage {get; set;}
        public int Verse { get; set; }
        public DateTime CreateAt { get; set; }
        public int IdTag { get; set; }
        public int IdComment { get; set; }
    }
}