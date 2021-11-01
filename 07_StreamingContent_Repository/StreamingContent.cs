using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public enum GenreType
    {
        Comedy = 1,
        Horror,
        Action,
        SciFi,
        Fantasy,
        RomCom,
        Thriller,
        Drama,
        Adventure
    }
    public enum MaturityRating
    {
        G,
        PG,
        PG_13,
        R,
        NC_17,
        TV_Y,
        TV_G,
        TV_PG,
        TV_14,
        TV_MA
    }
    public class StreamingContent
    {
        public StreamingContent() { }
        public StreamingContent(string title, string description, MaturityRating maturity, double starRating, GenreType genre)
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            MaturityRating = maturity;
            TypeOfGenre = genre;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_Y:
                    case MaturityRating.TV_G:
                    case MaturityRating.TV_PG:
                        return true;
                    default:
                        return false;
                }
            }
        }

        public GenreType TypeOfGenre { get; set; }
    }
}
