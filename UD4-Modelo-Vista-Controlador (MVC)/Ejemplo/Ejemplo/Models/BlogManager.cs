namespace Ejemplo.Models
{
    public class BlogManager : IDisposable
    {
        private readonly BlogContext _data;

        public BlogManager(BlogContext contexto)
        {
            _data = contexto;
        }

        public BlogManager()
        {
        }

        public IEnumerable<Post> GetLatestPosts(int max)
        {
            var posts = from post in _data.Posts
                        orderby post.Fecha descending
                        select post;
            return posts.Take(max).ToList();
        }
        public IEnumerable<Post> GetPostsByDate(int year, int month)
        {
            var posts = from post in _data.Posts
                        where post.Fecha.Month == month &&
                        post.Fecha.Year == year
                        orderby post.Fecha descending
                        select post;
            return posts.ToList();
        }
        public Post GetPost(string code)
        {
            return _data.Posts.FirstOrDefault(post => post.Codigo == code);
        }
        public void Dispose()
        {
            _data.Dispose();
        }
    }
}






