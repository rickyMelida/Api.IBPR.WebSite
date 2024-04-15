using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Test.DataTest
{
    public static class CoverImagesDetailsDataExample
    {
        public static List<CoverImagesDetails> GetCoverImagesDetails()
        {
            return (from coverImage in CoverImagesDataExample.GetCoverImages()
                    join images in ImagesDataExample.GetImages()
                    on coverImage.Image equals images.Id
                    join section in SectionsDataExamples.GetSections()
                    on coverImage.Section equals section.Id
                    select new CoverImagesDetails
                    {
                        Id = coverImage.Id,
                        Name = images.Name,
                        Picture = images.Picture,
                        Section = section.Section
                    }
            ).ToList<CoverImagesDetails>();
        }
    }
}