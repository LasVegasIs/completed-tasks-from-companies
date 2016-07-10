using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodsStore.WebUI.DBContext1
{
    public class Post
    {
        public Post(string Title1, string Content1, Blog blog1)
        {
            Title = Title1;
            Content = Content1;
            Blog = blog1;
        }
        public int PostId { get; set; }
        private string Title { get; set; }
        private string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}