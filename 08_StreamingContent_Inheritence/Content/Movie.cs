using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritence.Content
{
    public class Movie : StreamingContent
    {
        public Movie () { }
        public Movie(string title, string description, MaturityRating maturity, double starRating, GenreType genre,int releaseYear) : base(title,description,maturity,starRating,genre)
        {
            ReleaseYear = releaseYear;
        }
        public int ReleaseYear { get; set; }

    }
}
