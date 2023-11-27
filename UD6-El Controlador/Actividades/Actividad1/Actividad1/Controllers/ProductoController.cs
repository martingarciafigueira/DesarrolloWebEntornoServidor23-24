using Actividad1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    [Route("Producto")]
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return Content("Nos manda al Index");
        }
        //[Route("Listado/{categoria?}/{marca?}")]
        //public IActionResult Listado(string categoria, string marca)
        //{
        //    return Content("Nos muestra una lista de productos de categoria: " + categoria + " y marca: " + marca);
        //}
        //[Route("{id:int:length(4)}/{slug}")]
        //public IActionResult Detalle(int id, string slug)
        //{
        //    return Content("Nos muestra el detalle de un producto con ID: " + id + " y slug: " + slug);
        //}
        ////[Route("{q}/buscar")]
        ////public IActionResult Buscar(string q)
        ////{
        ////    return Content("Nos busca productos por nombre");
        ////}

        ////Actividad 3
        //[Route("Producto/Buscar/{terminoBusqueda?}")]
        //public IActionResult Buscar(string terminoBusqueda)
        //{
        //    if (terminoBusqueda == null)
        //    {
        //        RedirectToAction("Index");
        //    }
        //    return Content("Nos muestra la busqueda del " + terminoBusqueda);
        //}

        //[Route("Producto/Agregar/{id?}/{name?})")]
        //public IActionResult Agregar(Producto producto)
        //{
        //    if (producto == null)
        //    {
        //        //Mostramos formulario para añadir nuevo producto
        //    }
        //    //Agregamos el producto a la BD
        //    //Redirigimos a la página Index
        //    return View("Index");
        //}

        //[Route("Producto/Editar/{ID?}/{id?}/{name?})")]
        //public IActionResult Editar(int ID, Producto producto)
        //{
        //    if (ID == 0)
        //    {
        //        RedirectToAction("Index");
        //    }
        //    else if (producto == null)
        //    {
        //        //Mostramos formulario para añadir nuevo producto
        //    }
        //    else
        //    {
        //        //Actualizamos el producto en BD
        //    }
        //    return View("Index");
        //}

        //[Route("Producto/Eliminar/{id?}")]
        //public IActionResult Eliminar(int id)
        //{
        //    if (id == 0)
        //    {
        //        RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        //Borramos el producto de la BD
        //    }
        //    return View("Index");
        //}

    }
}
