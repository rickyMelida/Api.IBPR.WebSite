using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Domain.Entities
{
    public class TagByArticle
    {
        public int IdArticle { get; set; }
        public int IdTag { get; set; }
    }
}
