using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatchStackOverFlowProject
{
    class Post
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime createdOn { get; } = new DateTime ();
        public int voteCount = 0;
        
        public Post(string Title, string Description)
        { 
            if (string.IsNullOrEmpty(Title))
            {
                throw new ArgumentNullException(nameof(title));
            }
            if (string.IsNullOrEmpty(Description))
            {
                throw new ArgumentNullException(nameof(Description));
            }
            this.title = Title;
            this.description = Description;

        }

        public void UpVote()
        {
            switch (voteCount)
            {
                case -1:
                case 0:
                    voteCount += 1;
                    break;
           }
        }

        public void DownVote()
        {
            switch (voteCount)
            {
                case 0:
                case 1:
                    voteCount -= 1;
                    break;
            }
        }


    }
}
 