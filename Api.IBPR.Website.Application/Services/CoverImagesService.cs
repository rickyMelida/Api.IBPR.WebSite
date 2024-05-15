using System.Data.Common;
using System.Text.RegularExpressions;
using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Common;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Domain.Exceptions;
using Api.IBPR.Website.Domain.Request;

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

        public async Task<CoverImagesDetails> GetCoverImagesDetails(int id)
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
                        ).Where(e => e.Id == id).FirstOrDefault();

            if (result == null)
                throw new CoverImageException();

            return result;
        }

        public async Task<CoverImagesDetails> SetCoverImages(CoverImageRequest coverImagesDetails)
        {
            coverImagesDetails.Id = await _imageRepository.GetLastIdImage();

            string cleanedPictureString = Regex.Replace(coverImagesDetails.Picture, @"[^A-Za-z0-9+/=]", "");
            
            if (cleanedPictureString.Length % 4 != 0)
                cleanedPictureString = cleanedPictureString.PadRight(cleanedPictureString.Length + (4 - cleanedPictureString.Length % 4), '=');
            
            
            var imageadded = await _imageRepository.SetImage(new Image
            {
                Id = coverImagesDetails.Id + 1,
                Name = coverImagesDetails.Name,
                Picture = Convert.FromBase64String(cleanedPictureString)
            });

            var coverImage = new CoverImages
            {
                Id = await _coverImageRepository.GetLastIdCoverImage() + 1,
                Section = await _sectionRepository.GetSectionId(coverImagesDetails.Section.Trim()),
                Image = imageadded.Id
            };

            await _coverImageRepository.SetCoverImage(coverImage);

            return await GetCoverImagesDetails(coverImagesDetails.Id);

        }
    }
}