using Api.IBPR.Website.Domain.Common;
using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Repositories
{
    public interface ICoverImage
    {
        Task<List<CoverImages>> GetCoverImage();
        Task<CoverImages> SetCoverImage(CoverImages coverImage);
        Task<int> GetLastIdCoverImage();

    }
}