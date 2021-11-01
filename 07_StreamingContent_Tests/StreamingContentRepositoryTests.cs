using _07_StreamingContent_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void AddContent_ShouldAddContentToDirectory()
        {
            // Arrange
            StreamingContent content = new StreamingContent();

            StreamingContentRepository repository = new StreamingContentRepository();
            // Act

            bool addResult = repository.AddContentToDirectory(content);
            // Assert
            Assert.IsTrue(addResult);
        }
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            // Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            repo.AddContentToDirectory(content);

            // Act
            List<StreamingContent> contents = repo.GetContents();

            bool directoryHasContent = contents.Contains(content);
            // Assert
            Assert.IsTrue(directoryHasContent);
        }

        private StreamingContentRepository _repo;
        private StreamingContent _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode", MaturityRating.R, 7.6, GenreType.Thriller);

            StreamingContent movieOne = new StreamingContent("Toy Story", "A story about living toys", MaturityRating.PG, 8.8, GenreType.Adventure);

            StreamingContent movieTwo = new StreamingContent("Star Wars", "Wars in the stars", MaturityRating.PG_13, 8.5, GenreType.SciFi);

            StreamingContent tvShow = new StreamingContent("Spongebob", "Porous is he", MaturityRating.TV_Y, 9.0, GenreType.Comedy);

            _repo.AddContentToDirectory(_content);
            _repo.AddContentToDirectory(movieOne);
            _repo.AddContentToDirectory(movieTwo);
            _repo.AddContentToDirectory(tvShow);
            
        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            // Arrange
            // Arrange is done in the test initialize
            // Act
            StreamingContent foundContent = _repo.GetContentByTitle("Rubber");
            // Assert
            Assert.AreEqual(_content, foundContent);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            // Arrange
            StreamingContent newContent = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode.", MaturityRating.R, 10, GenreType.Thriller);
            // Act
            bool updateResult = _repo.UpdateExistingContentByTitle("Rubber", newContent);
            // Assert
            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            // Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");
            // Act
            bool removeResult = _repo.DeleteExistingContent(content);
            // Assert
            Assert.IsTrue(removeResult);
        }

        [TestMethod]
        public void DeleteExistingContentByTitle_ShouldReturnTrue()
        {
            Assert.IsTrue(_repo.DeleteExistingContentByTitle("Rubber"));
        }

        [TestMethod]
        public void GetByMaturityRating_ShouldReturnCorrectContent()
        {
            // Arrange
            // Arrange is done in the test initialize
            // Act
            List<StreamingContent> foundContent = _repo.GetByMaturityRating(MaturityRating.R);
            bool newListHasContent = foundContent.Contains(_content);
            // Assert
            Assert.IsTrue(newListHasContent);
        }

        [TestMethod]
        public void GetFamilyFriendly_ShouldReturnAllFamilyFriendlyContent()
        {
            List<StreamingContent> foundContent = _repo.GetFamilyFriendlyMovies();
            foreach(StreamingContent content in foundContent)
            {
                Assert.IsTrue(content.IsFamilyFriendly);
            }
        }

        [DataTestMethod]
        [DataRow(3,9)]
        [DataRow(6.5,10)]
        [DataRow(7,8)]
        public void GetByStarRating_ShouldReturnContentWithinRange(double x, double y)
        {
            List<StreamingContent> foundContent = _repo.GetByStarRatingRange(x, y);

            foreach (StreamingContent content in foundContent)
            {
                Assert.IsTrue(content.StarRating >= x && content.StarRating <= y);
            }
        }
    }
}
