using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Domain.Exceptions
{
    public class TagException: Exception
    {
        public TagException(): base("No se encontro ningun Tag con ese ID") { }
        public TagException(string message): base(message) { }
    }
}