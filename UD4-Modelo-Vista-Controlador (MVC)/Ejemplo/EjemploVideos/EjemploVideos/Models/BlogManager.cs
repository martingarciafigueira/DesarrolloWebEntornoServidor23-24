namespace EjemploVideos.Models
{
    public class BlogManager
    {
        private readonly BlogContext _data;

        public BlogManager(BlogContext data)
        {
            _data = data;
        }

        public Post GetPost(int PostId)
        {
            return _data.Posts.FirstOrDefault(post => post.PostId == PostId);
        }
    }
}
