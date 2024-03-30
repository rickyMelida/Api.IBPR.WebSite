using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Domain.Exceptions
{
    public class ArticleException: Exception
    {
        public ArticleException(): base("No hay articulos a mostrar") { }
        public ArticleException(string message): base(message){ }
    }
}