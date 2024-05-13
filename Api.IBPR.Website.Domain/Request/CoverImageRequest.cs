using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Domain.Request
{
    public class CoverImageRequest
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Section { get; set; }

    }
}
    