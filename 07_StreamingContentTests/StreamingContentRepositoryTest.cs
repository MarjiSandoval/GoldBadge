using Microsoft.VisualStudio.TestTools.UnitTesting;
using _07_StreamingContentRepository1;
using System;
using System.Collections.Generic;

namespace _07_StreamingContentTests
{
    [TestClass]
    public class StreamingContentRepositoryTest
    {
        [TestMethod]
        public void AddContent_ShouldAddContentToDirectory()
        {
            //Arrange
            StreamingContent content = new StreamingContent();

            StreamingContentRepository repository = new StreamingContentRepository();

            //Act
            bool addResult = repository.AddContentToDirectory(content);

            //Assert
            Assert.IsTrue(addResult);

        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //Arrange
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
        private StreamingContent _contentA;
        private StreamingContent _contentB;
        private StreamingContent _contentC;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _contentA = new StreamingContent("Idk", "????", MaturityRating.G, 5,GenreType.Fantasy);
            _contentB = new StreamingContent("Really dont know", "????", MaturityRating.G, 5, GenreType.Fantasy);
            _contentC = new StreamingContent("Something", "????", MaturityRating.G, 5, GenreType.Fantasy);
            _content = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode", MaturityRating.R, 7.6, GenreType.Thriller);


            _repo.AddContentToDirectory(_content);
            _repo.AddContentToDirectory(_contentA);
            _repo.AddContentToDirectory(_contentB);
            _repo.AddContentToDirectory(_contentC);
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
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");
            //Act
            bool removeResult = _repo.DeleteExistingContent(content);
            //Assert
            Assert.IsTrue(removeResult);
        }

        //challenge, make these ropo methods and test them

        //Delete By Content Title
        [TestMethod]
        public void DeleteByContentTitle_ShouldReturnTrue()
        {
            
            bool isSuccessful = _repo.DeleteByTitle("Rubber");
            Assert.IsTrue(isSuccessful);
        }
        //Get all movies of a certain maturity rating
        [TestMethod]
        public void GetAllGRatedMovies_ShouldReturnAllGRatedMovies()
        {
            List<StreamingContent> content = _repo.GetAllGRatedMovies();

            Assert.IsTrue(content.Contains(_contentA));
            Assert.IsTrue(content.Contains(_contentB));
            Assert.IsTrue(content.Contains(_contentB));
        }
        //get all family friendly movies
        [TestMethod]
        public void GetAllFamilyFriendlyMovies_ReturnAllFamilyFriendlyMovies()
        {
            List<StreamingContent> content = _repo.GetAllFamilyFriendlyMovies();

            

            Assert.IsTrue(content.Contains(_contentB));
            Assert.IsTrue(content.Contains(_contentA));
        }

        //get all movies with in a star rating range. (So I want all movies from 4-7 for example)
        [TestMethod]
        public void GetAllMoviesByStarRating_ReturnAllMoviesWith4_7 ()
        {
            List<StreamingContent> content = _repo.GetMovies();
            Assert.AreEqual(3, content.Count);
        }
    }
}

