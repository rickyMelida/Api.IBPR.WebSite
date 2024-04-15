using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Application.Services;
using Api.IBPR.Website.Domain.Common;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Test.DataTest;
using Api.IBPR.Website.Test.Utils;
using Moq;
using NUnit.Framework;

namespace Api.IBPR.Website.Test.CoverImagesTest
{
    public class CoverImagesControllerTests
    {
        public List<CoverImages>? expectedCoverImages = null;
        public List<Image>? expectedImages = null;
        public List<Sections>? expectedSections = null;
        public List<CoverImagesDetails>? expectedCoverImagesDetails = null;

        [SetUp]
        public void SetUp()
        {
            expectedCoverImages = CoverImagesDataExample.GetCoverImages();
            expectedImages = ImagesDataExample.GetImages();
            expectedSections = SectionsDataExamples.GetSections();
            expectedCoverImagesDetails = CoverImagesDetailsDataExample.GetCoverImagesDetails();
        }
        
        [Test]
        public async Task GetCoverImages_Should_Return_List_CoverImages()
        {
            // Arrange   
            var coverImageRepositoryMock = new Mock<ICoverImage>();
            var imageRepositoryMock = new Mock<IImage>();
            var sectionRepositoryMock = new Mock<ISection>();
            var coverImagesServices = new CoverImagesService(coverImageRepositoryMock.Object, imageRepositoryMock.Object, sectionRepositoryMock.Object);

            coverImageRepositoryMock.Setup(a => a.GetCoverImage()).ReturnsAsync(expectedCoverImages);
            imageRepositoryMock.Setup(a => a.GetImages()).ReturnsAsync(expectedImages);
            sectionRepositoryMock.Setup(a => a.GetSections()).ReturnsAsync(expectedSections);

            // Act
            var actual = await coverImagesServices.GetCoverImages();
            
            // Assert
            for(int i=0; i < actual.Count; i++){
                bool isTheSame = VerifyObjects.IsTheSameObjects(actual[i], expectedCoverImagesDetails[i]);

                Assert.IsTrue(isTheSame);
            }

        }

    }
}