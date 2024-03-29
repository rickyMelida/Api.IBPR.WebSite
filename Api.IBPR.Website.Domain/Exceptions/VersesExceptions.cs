using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Domain.Exceptions
{
    [Serializable]
    public class VersesExceptions : Exception
    {
        public VersesExceptions(): base("No hay versiculos que mostrar") { }
        public VersesExceptions(string message): base(message) { }

    }
}