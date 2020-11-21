using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        private List<StreamingContent> _listOfContent = new List<StreamingContent>();

        //create
        public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content);
        }

        //read
        public List<StreamingContent> GetContentList()
        {
            return _listOfContent;
        }
        //update
        public void UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            //Find content
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            //update content
            if(oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                return true;
            }
            else
            {
                return false;
            }
        }

        //delete
        public bool RemoveContentFromList(string title)
        {
            StreamingContent content = GetContentByTitle(title);

            if( content == null)
            {
                return false;
            }

            int initialCount = _listOfContent;
            _listOfContent.Remove(content);

            if (initialCount > _listOfContent)
            {
                return true; 
            }
            else
            {
                return false;
            }

        }

        //Helper Method
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _listOfContent)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }

            return null;
        }
    }
}
