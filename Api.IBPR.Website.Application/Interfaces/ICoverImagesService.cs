using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Domain.Request;

namespace Api.IBPR.Website.Application.Interfaces
{
    public interface ICoverImagesService
    {
        Task<List<CoverImagesDetails>> GetCoverImages();
        Task<CoverImagesDetails> GetCoverImagesDetails(int id);
        Task<CoverImagesDetails> SetCoverImages(CoverImageRequest coverImagesDetails);
    }
}