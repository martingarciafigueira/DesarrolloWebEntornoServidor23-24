using EjemploVideos.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjemploVideos.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogContext _contexto;

        public BlogController(BlogContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewPost(int PostId)
        {
            var manager = new BlogManager(_contexto);
            var postElegido = manager.GetPost(PostId);
            return View(postElegido);
        }
    }
}
