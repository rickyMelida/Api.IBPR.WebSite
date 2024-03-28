using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Services
{
    public class VerseService: IVerseServices
    {
        private readonly IVerse _verseRepository;
        private readonly ISection _sectionRepository;
        private readonly IMainVerse _mainVerseRepository;

        public VerseService(IVerse verseRepository, ISection sectionRepository, IMainVerse mainVerseRepository) =>
            (_verseRepository, _sectionRepository, _mainVerseRepository) = (verseRepository, sectionRepository, mainVerseRepository);

        public async Task<List<HeaderVerses>> GetMainVerses()
        {

            var data = from mainVerse in await _mainVerseRepository.GetMainVerses()
                       join section in await _sectionRepository.GetSections()
                       on mainVerse.Section equals section.Id
                       join verse in await _verseRepository.GetVerses()
                       on mainVerse.IdVerse equals verse.Id
                       select new HeaderVerses
                       {
                           Id = mainVerse.Id,
                           Section = section.Section,
                           Text = verse.Text,
                           Book = verse.Book,
                           Chapter = verse.Chapter,
                           Verse = verse.Versse
                       };
        
            return data.ToList<HeaderVerses>();
        }
    }
}