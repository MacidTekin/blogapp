using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Entity
{
    public class User
    {
        public int UserId { get; set; }

        public string? UserName { get; set; }

        public string? Name { get; set; }
        
        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? Image { get; set; }

        public List<Post> Posts { get; set; } = new List<Post>(); //bir kullanıcı birden fazla post yayınlayabilir.

        public List<Comment> Comments { get; set; } = new List<Comment>(); //Kullanıcının yaptığı tüm yorumlara liste halinde ulaşabilriz.
    }
}