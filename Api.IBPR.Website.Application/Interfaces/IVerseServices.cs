using Api.IBPR.Website.Domain.Common;
using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Interfaces
{
    public interface IVerseServices
    {
        Task<List<HeaderVerses>> GetMainVerses();
        Task<DefaultResponse> SetMainVerses(HeaderVerses headerVerse);
    }
}