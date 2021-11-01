using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class StreamingContentRepository
    {
        // Repository Pattern

        // Directory, mimics a database
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        // CRUD basic necessities of repository pattern


        // Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        // Read
        // Get all
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        } 

        // Get single
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }

        // Update
        public bool UpdateExistingContentByTitle(string originalTitle,StreamingContent content)
        {
            // Breakpoint through this
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if (oldContent != null)
            {
                oldContent.Title = content.Title;
                oldContent.Description = content.Description;
                oldContent.StarRating = content.StarRating;
                oldContent.MaturityRating = content.MaturityRating;
                oldContent.TypeOfGenre = content.TypeOfGenre;

                return true;
            }
            else
                return false;
        }

        // Delete
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }

    }
}
