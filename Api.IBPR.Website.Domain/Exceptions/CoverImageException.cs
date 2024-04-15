using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Domain.Exceptions
{
    public class CoverImageException: Exception
    {
        public CoverImageException(): base("No hay ninguna imagen de portada aun subido") { }
        
        public CoverImageException(string message) : base(message) { }
    }
}