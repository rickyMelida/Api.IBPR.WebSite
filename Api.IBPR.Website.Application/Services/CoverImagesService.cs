using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Domain.Exceptions;

namespace Api.IBPR.Website.Application.Services
{
    public class CoverImagesService : ICoverImagesService
    {
        private readonly ICoverImage _coverImageRepository;
        private readonly IImage _imageRepository;
        private readonly ISection _sectionRepository;

        public CoverImagesService(ICoverImage coverImageRepository, IImage imageRepository, ISection sectionRepository) =>
            (_coverImageRepository, _imageRepository, _sectionRepository) = (coverImageRepository, imageRepository, sectionRepository);

        public async Task<List<CoverImagesDetails>> GetCoverImages()
        {
            var result = (from coverImage in await _coverImageRepository.GetCoverImage()
                          join images in await _imageRepository.GetImages()
                          on coverImage.Image equals images.Id
                          join section in await _sectionRepository.GetSections()
                          on coverImage.Section equals section.Id
                          select new CoverImagesDetails
                          {
                              Id = coverImage.Id,
                              Name = images.Name,
                              Picture = images.Picture,
                              Section = section.Section
                          }
            ).ToList<CoverImagesDetails>();

            if (result.Count == 0)
                throw new CoverImageException();

            return result;
        }
    }
}