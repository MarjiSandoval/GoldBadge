using _07_StreamingContentRepository1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_StreamingContentTests
{
}
[TestClass]
public class StreamingContentTests
{
    //Basic functionality
    [TestMethod]
    public void SetTitle_GetCorrectString()
    {
        StreamingContent content = new StreamingContent();

        content.Title = "Toy Story";

        string expected = "Toy Story";
        string actual = content.Title;

        Assert.AreEqual(expected, actual);
    }

    //Test familyFriendly setting
    [DataTestMethod]

    [DataRow(MaturityRating.G, true)]
    [DataRow(MaturityRating.TV_MA,true)]
    [DataRow(MaturityRating.R,false)]
    [DataRow(MaturityRating.TV_G,true)]
    public void SetMaturityRating_ShouldGetCorrectIsFamilyFriendlyRating(MaturityRating maturity, bool expectedFamilyFriendly)
    {
        //Triple A Paradigm

        // Arrange => SEt the stage for testing
        StreamingContent content = new StreamingContent("Some title", "some description", maturity, 3.5, GenreType.Horror);
        // Act => Execute code we run
        bool actual = content.IsFamilyFriendly;
        bool expected = expectedFamilyFriendly;
        // Assert => Call our ssertions
        Assert.AreEqual(expected, actual);

    }

}