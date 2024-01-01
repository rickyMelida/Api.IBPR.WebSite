using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Domain;

namespace Api.IBPR.Website.Persistence.Context
{
    public class DbContext
    {
        public DbSet<Image> Image {get; set;}
    }
}