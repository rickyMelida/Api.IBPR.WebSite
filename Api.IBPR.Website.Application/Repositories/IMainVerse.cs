using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Repositories
{
    public interface IMainVerse
    {
        Task<MainVerse> GetMainVerse(int id);
        Task<List<MainVerse>> GetMainVerseByName(string name);
    }
}
