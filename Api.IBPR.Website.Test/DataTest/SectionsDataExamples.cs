using System.Collections.Generic;
using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Test.DataTest
{
    public static class SectionsDataExamples
    {
        public static List<Sections> GetSections()
        {
            return new List<Sections>
            {
                new Sections { Id=1, Section="Main" },
                new Sections { Id=2, Section="Counseling" }
            };
        }
    }
}