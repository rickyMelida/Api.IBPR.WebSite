using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Domain.Entities
{
    public class Verse
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Chapter { get; set; }
        public int Versse { get; set; }
    }
}