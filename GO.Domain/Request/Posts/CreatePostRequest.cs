using System;
using System.Collections.Generic;
using System.Text;

namespace GO.Domain.Request.Posts
{
    public class CreatePostRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int IdCategory { get; set; }
    }
}
