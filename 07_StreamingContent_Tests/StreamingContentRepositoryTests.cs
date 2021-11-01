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

            _repo.AddContentToDirectory(_content);
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
    }
}
