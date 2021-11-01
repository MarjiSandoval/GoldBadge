using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContentRepository1
{
    public class StreamingContentRepository
    {
        //Repository Patern

        // Directory mimics a database
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //CRUD basic necessities of repository pattern


        // Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        // Read
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }
        //Get single
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
        public bool UpdateExistingContentByTitle(string originalTitle, StreamingContent content)
        {
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

        //challenge, make these ropo methods and test them

        //Delete By Content Title

        public bool DeleteByTitle(string title)
        {
            var content = GetContentByTitle(title);
            bool isSuccessful = _contentDirectory.Remove(content);
            return isSuccessful;
        }
            

        //Get all movies of a certain maturity rating

        public List<StreamingContent> GetAllGRatedMovies()
        {
            List<StreamingContent> contents = new List<StreamingContent>();
            foreach (StreamingContent item in _contentDirectory)
            {
                if (item.MaturityRating == MaturityRating.G) 
                {
                    contents.Add(item);
                }

            }
            return contents;
        }
        //get all family friendly movies
        public List<StreamingContent> GetAllFamilyFriendlyMovies()
        {
            //This is my empty list of streaming content

            List<StreamingContent> content = new List<StreamingContent>();

            //I'm going to loop through my database
            //In this case its my _contentDirectory
            //For each streaming content type named item
            //inside of this _contentDirectory
            foreach (StreamingContent item in _contentDirectory)
            {
                //if such item is family friendly
                if (item.IsFamilyFriendly == true)
                {
                    //add it to my empty list
                    content.Add(item);

                }
            }
            // after the list is filled up, I'll return the list
            return content;
        }

        //get all movies with in a star rating range. (So I want all movies from 4-7 for example)

        public List<StreamingContent> GetMovies()
        {
            List<StreamingContent> content = new List<StreamingContent>();

            foreach (StreamingContent item in _contentDirectory)
            {
                if (item.StarRating >=4 && item.StarRating <= 7)
                {
                    content.Add(item);
                }
            }
            return content;
            

        }

            

    }
}
