using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Application.Services;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Test.DataTest;
using Moq;
using NUnit.Framework;

namespace Api.IBPR.Website.Test.Verses
{
    public class VerseControllerTests
    {
        public List<Verse> expectedVerses;
        public List<MainVerse> expectedMainVerses;
        public List<Sections> expectedSections;
        public List<HeaderVerses> expectedHeaderVerses;

        [SetUp]
        public void SetUp()
        {
            expectedVerses = VersesDataExample.GetAllVerses();
            expectedMainVerses = MainVesesDataExample.GetAllMainVerses();
            expectedSections = SectionsDataExamples.GetSections();
            expectedHeaderVerses = HeaderVersesDataExample.GetHeaderVerses();
        }

        [Test]
        [Ignore("This is ignore because don't make")]
        public async Task GetHaederVerses_Should_Return_List_Header_Verses()
        {
            // Arrange
            var verseRepositoryMock = new Mock<IVerse>();
            var sectionRepositoryMock = new Mock<ISection>();
            var mainVerseRepositoryMock = new Mock<IMainVerse>();
            var verseService = new VerseService(verseRepositoryMock.Object, sectionRepositoryMock.Object, mainVerseRepositoryMock.Object);

            verseRepositoryMock.Setup(a => a.GetVerses()).ReturnsAsync(expectedVerses);
            sectionRepositoryMock.Setup(a => a.GetSections()).ReturnsAsync(expectedSections);
            mainVerseRepositoryMock.Setup(a => a.GetMainVerses()).ReturnsAsync(expectedMainVerses);

            // Act
            List<HeaderVerses> actual = await verseService.GetMainVerses();

            //Assert
            //Assert.AreEqual(expectedHeaderVerses, actual);
            Assert.AreSame(expectedHeaderVerses, actual);
        }

        [Test]
        public async Task GetHeaderVerses_Should_Return_Just_A_Text_Of_Verse()
        {
            // Arrange
            var verseRepositoryMock = new Mock<IVerse>();
            var sectionRepositoryMock = new Mock<ISection>();
            var mainVerseRepositoryMock = new Mock<IMainVerse>();
            var verseService = new VerseService(verseRepositoryMock.Object, sectionRepositoryMock.Object, mainVerseRepositoryMock.Object);

            verseRepositoryMock.Setup(a => a.GetVerses()).ReturnsAsync(expectedVerses);
            sectionRepositoryMock.Setup(a => a.GetSections()).ReturnsAsync(expectedSections);
            mainVerseRepositoryMock.Setup(a => a.GetMainVerses()).ReturnsAsync(expectedMainVerses);

            // Act
            var actual = await verseService.GetMainVerses();

            //Assert
            for (int i = 0; i < expectedHeaderVerses.Count; i++)
                Assert.AreEqual(expectedHeaderVerses[i].Text, actual[i].Text);
        }
    }
}