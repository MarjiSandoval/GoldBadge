﻿using System;
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
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        } 

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
        // Delete
    }
}
