using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Common;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Domain.Exceptions;

namespace Api.IBPR.Website.Application.Services
{
    public class VerseService : IVerseServices
    {
        private readonly IVerse _verseRepository;
        private readonly ISection _sectionRepository;
        private readonly IMainVerse _mainVerseRepository;

        public VerseService(IVerse verseRepository, ISection sectionRepository, IMainVerse mainVerseRepository) =>
            (_verseRepository, _sectionRepository, _mainVerseRepository) = (verseRepository, sectionRepository, mainVerseRepository);

        public async Task<List<HeaderVerses>> GetMainVerses()
        {
            var data = (from mainVerse in await _mainVerseRepository.GetMainVerses()
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
                        }).ToList<HeaderVerses>();

            if (data.Count == 0)
                throw new VersesExceptions("No se encontraron datos");

            return data;
        }

        public async Task<DefaultResponse> SetMainVerses(HeaderVerses headerVerse)
        {
            try
            {
                int idMainVerse = await _mainVerseRepository.GetLastId() + 1;
                int idVerse = await _verseRepository.GetLastId() + 1;
                int sectionId = await _sectionRepository.GetSectionId(headerVerse.Section.Trim());

                MainVerse mainVerse = new MainVerse
                {
                    Id = idMainVerse,
                    Section = sectionId,
                    IdVerse = idVerse
                };

                Verse verse = new Verse
                {
                    Id = idVerse,
                    Text = headerVerse.Text,
                    Book = headerVerse.Book,
                    Chapter = headerVerse.Chapter,
                    Versse = headerVerse.Verse
                };

                await _mainVerseRepository.SetMainVerse(mainVerse);
                await _verseRepository.SetVerse(verse);

                return new DefaultResponse { Code = 0, Message = "Ok" };
            }
            catch (VersesExceptions error)
            {
                return new DefaultResponse { Code = 1, Message = error.Message };
            }

        }
    }
}