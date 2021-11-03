using _07_StreamingContent_Repository;
using _08_StreamingContent_Inheritence.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritence
{
    public class StreamingRepository : StreamingContentRepository
    {
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    // Casting our content of streaming content into Show type.
                    return (Show)content;
                }
            }
            return null;
        }

        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Movie))
                {
                    return (Movie)content;
                }
            }
            return null;
        }


    }
}
