using _08_StreamingContent_Inheritence;
using _08_StreamingContent_Inheritence.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreaminContentInheritenceTest
    {
        [TestMethod]
        public void ContentInheritence_ShouldReturnMovie()
        {
            Movie joe = new Movie("Joe Dirt", "A man with a meteor", _07_StreamingContent_Repository.MaturityRating.PG_13, 6.7, _07_StreamingContent_Repository.GenreType.Comedy, 2001);
            StreamingRepository repo = new StreamingRepository();

            repo.AddContentToDirectory(joe);
            Movie fetchedFilm = repo.GetMovieByTitle("Joe Dirt");

            Assert.IsInstanceOfType(fetchedFilm, typeof(Movie));
            Console.WriteLine(fetchedFilm.ReleaseYear);
        }
    }
}
