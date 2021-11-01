using _07_StreamingContent_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        // Basic functionality
        [TestMethod]
        public void SetTitle_ShouldGetCorrectString()
        {
            // Arrange
            StreamingContent content = new StreamingContent();

            content.Title = "Toy Story";
            // ACt
            string expected = "Toy Story";
            string actual = content.Title;
            // Assert
            Assert.AreEqual(expected, actual);
             
        }
        // Test IsFamilyFriendly
        [DataTestMethod]
        [DataRow(MaturityRating.G,true)]
        [DataRow(MaturityRating.TV_G,true)]
        [DataRow(MaturityRating.R,false)]
        [DataRow(MaturityRating.TV_MA, false)]
        public void SetMaturityRating_ShouldGetCorrectIsFamilyFriendlyRating( MaturityRating maturity,bool expectedFamilyFriendly)
        {
            // Triple A Paradigm

            // Arrange => Set the stage for testing
            StreamingContent content = new StreamingContent("Some title", "Some description", maturity, 3.5, GenreType.Horror);
            // Act => Execute code we run
            bool actual = content.IsFamilyFriendly;
            bool expected = expectedFamilyFriendly;
            // Assert => Call our assertions
            Assert.AreEqual(expected, actual);
        }

    }
}
