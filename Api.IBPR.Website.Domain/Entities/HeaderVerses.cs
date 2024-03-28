using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Domain.Entities
{
    public class HeaderVerses
    {
        public int Id { get; set; }
        public string Section { get; set; }
        public string Text { get; set; }
        public string Book {get; set;}
        public int Chapter { get; set; }
        public int Verse { get; set; }

    }
}