using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Domain.Common
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Day { get; set; }
        public string Hour { get; set; }
    }
}