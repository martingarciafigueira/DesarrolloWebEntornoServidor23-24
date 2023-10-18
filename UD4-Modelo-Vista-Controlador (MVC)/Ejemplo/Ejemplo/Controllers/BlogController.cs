using Ejemplo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejemplo.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogContext _contexto;

        public BlogController(BlogContext contexto)
        {
            _contexto = contexto;
        }

        BlogManager manager = new BlogManager();

        public IActionResult Index()
        {
            var posts = manager.GetLatestPosts(10); // 10 ultimos posts
            return View("Index", posts);
        }

        public IActionResult Archive(int year, int month)
        {
            var posts = manager.GetPostsByDate(year, month);
            return View(posts);
        }

        public IActionResult ViewPost(string code)
        {
            var manager = new BlogManager(_contexto);
            var post = manager.GetPost(code);
            if (post == null)
                return NotFound();
            else
                return View(post);
        }

        IProductsCatalog catalog;

        public ProductsController(IProductsCatalog productsCatalog)
        {
            this.catalog = productsCatalog;
        }

        public ProductsController()
        {
            this.catalog = new ProductsCatalog();
        }

        // ...
        // Other actions and code

        public ActionResult Magazine()
        {
            List<Post> products = HttpContext.Session.Get("ShopCart") as List<Post>;

            bool shopActive = (bool)HttpContext.["PostActive"];



            List<Post> bestSellers = Cache["BestSellers"] as List<Post>;

            return View();
        }


    }
}



