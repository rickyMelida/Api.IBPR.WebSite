using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Test.DataTest
{
    public static class HeaderVersesDataExample
    {
        public static List<HeaderVerses> GetHeaderVerses()
        {
            var data = (from mainVerse in MainVesesDataExample.GetAllMainVerses()
                        join section in SectionsDataExamples.GetSections()
                        on mainVerse.Section equals section.Id
                        join verse in VersesDataExample.GetAllVerses()
                        on mainVerse.IdVerse equals verse.Id
                        select new HeaderVerses
                        {
                            Id = mainVerse.Id,
                            Section = section.Section,
                            Text = verse.Text,
                            Book = verse.Book,
                            Chapter = verse.Chapter,
                            Verse = verse.Versse
                        }).ToList<HeaderVerses>();

            return data;
            /*return new List<HeaderVerses>
            {
                new HeaderVerses { Id=1, Section="Main", Text="Ustedes son mis Amigos, si hacen lo que les mando", Book="Juan", Chapter=15, Verse=14},
                new HeaderVerses { Id=2, Section="Main", Text="Vengan a mí todos los que están cansados y llevan cargas pesadas, y yo les daré descanso.", Book="Mateo", Chapter=11, Verse=28}
            };*/
        }
    }
}