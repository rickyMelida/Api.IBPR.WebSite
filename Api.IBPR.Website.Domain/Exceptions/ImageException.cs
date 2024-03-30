using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Domain.Exceptions
{
    public class ImageException: Exception
    {
        public ImageException(): base("No existe imagen.") { }
        public ImageException(string message): base(message) { }
    }
}