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
    }
}
