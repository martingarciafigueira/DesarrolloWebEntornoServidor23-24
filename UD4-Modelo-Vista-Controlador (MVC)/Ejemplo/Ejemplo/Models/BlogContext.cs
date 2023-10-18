using Microsoft.EntityFrameworkCore;

namespace Ejemplo.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        { }
        public DbSet<Post> Posts { get; set; }
    }
}



