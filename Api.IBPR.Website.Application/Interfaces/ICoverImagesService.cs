using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Interfaces
{
    public interface ICoverImagesService
    {
        Task<List<CoverImagesDetails>> GetCoverImages();
    }
}