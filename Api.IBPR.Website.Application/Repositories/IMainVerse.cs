using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Repositories
{
    public interface IMainVerse
    {
        Task<MainVerse> GetMainVerse(int id);
        Task<List<MainVerse>> GetMainVerses();
        Task<MainVerse> SetMainVerse(MainVerse mainVerse);
        Task UpdateMainVerse(int id, MainVerse mainVerseUpdate);
        Task DeleteMainVerse(int id);
    }
}
