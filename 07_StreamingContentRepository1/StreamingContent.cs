using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContentRepository1
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
        G = 1,
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
        public StreamingContent(string title, string description, MaturityRating maturity,double starRating, GenreType genre )
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            MaturityRating = maturity;
            TypeOfGenre = genre;
        }
        public StreamingContent(){}
        public GenreType TypeOfGenre { get; set; }
        public bool IsFamilyFriendly 
        { 
            get 
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_G:
                    case MaturityRating.TV_PG:
                    case MaturityRating.TV_Y:
                        return true;
                    default:
                        return false;

                }
            } 
        }
        public MaturityRating MaturityRating { get; set; }
        public double StarRating { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }
}
