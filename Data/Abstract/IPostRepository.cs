using BlogApp.Entity;

namespace BlogApp.Data.Abstract
{
    public interface IPostRepository
    {
        IQueryable<Post> Posts { get; }//IQueryable olması demek Context üzerinden bütün postları aldığımızda ekstra filtrelemeye devam edebiliriz.
        void CreatePost(Post post);
    }
}
