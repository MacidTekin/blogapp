using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Entity
{
    public class Post
    {
        public int PostId { get; set; }

        public string? Title { get; set; }

        public string? Content { get; set; }

        public string? Url { get; set; }

        public string? Image { get; set; }

        public DateTime PublishedOn { get; set; }

        public bool IsActive { get; set; }

        public int UserId { get; set; }

        public User User { get; set; } = null!; //Her bir postun bir user bilgisi olacak ve boş olmayacak.

        public List<Tag> Tags { get; set; } = new List<Tag>(); //Her bir postun birden fazla tag bilgisi olabilir.

        public List<Comment> Comments { get; set; } = new List<Comment>(); //Bir Postta birden fazla Comment olabilir.
    }
}