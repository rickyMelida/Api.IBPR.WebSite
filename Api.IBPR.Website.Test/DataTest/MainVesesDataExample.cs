using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Test.DataTest
{
    public static class MainVesesDataExample
    {
        public static List<MainVerse> GetAllMainVerses()
        {
            return new List<MainVerse>
            {
                new MainVerse { Id=1, IdVerse=1, Section=1 },
                new MainVerse { Id=2, IdVerse=2, Section=1 }
            };
        }
    }
}