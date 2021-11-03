using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritence.Content
{
    public class Show : StreamingContent
    {
        public Show () { }
        public Show(
            string title, string description, MaturityRating maturity, double starRating, GenreType genre,int seasonCount, int episodeCount,double avgRunTime) : base(title, description, maturity, starRating, genre)
        {
            SeasonCount = seasonCount;
            EpisodeCount = episodeCount;
            AverageRunTime = avgRunTime;
        }

        public Show(string title, string description, MaturityRating maturity, double starRating, GenreType genre, int seasonCount, int episodeCount, double avgRunTime, List<Episode> episodes) : this(title, description,maturity,starRating, genre, seasonCount, episodeCount, avgRunTime)
        {
            Episodes = episodes;
        }

        public List<Episode> Episodes { get; set; } = new List<Episode>();

        public int SeasonCount { get; set; }
        public int EpisodeCount { get; set; }
        public double AverageRunTime { get; set; }
    }

    public class Episode
    {
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int EpisodeNumber { get; set; }
        public int SeasonNumber { get; set; }

    }
}
