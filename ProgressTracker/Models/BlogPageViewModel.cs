using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgressTracker.Models
{
    public class BlogPageViewModel
    {
        public string Title { get; set; }

        public string Excerpt { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public BlogPageViewModel(string title, string excerpt, string content)
        {
            Title = title;
            Excerpt = excerpt;
            Content = content;
            DateTime currentDate = DateTime.Now.ToUniversalTime();
            CreatedDate = currentDate;
            ModifiedDate = currentDate;
        }
    }
}