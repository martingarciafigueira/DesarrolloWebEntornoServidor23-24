using Ejercicio1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Ejercicio1.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ProductoContext _contexto;

        public ProductoController(ProductoContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VerProducto(int codigo)
        {
            List<Producto> listaProductos = new List<Producto>();

            listaProductos.Add(_contexto.Producto.FirstOrDefault(producto => producto.codigo == codigo));

            return View("ListaProductos", listaProductos);
        }

        [HttpPost]
        public IActionResult GuardarProducto(int codigo, string nombre, double precio)
        {
            var productoAModificar = _contexto.Producto.FirstOrDefault(producto => producto.codigo == codigo);

            productoAModificar.nombre = nombre;
            productoAModificar.precio = precio;

            _contexto.SaveChanges();

            return View("Index");
        }

        [HttpGet]
        public IActionResult EditarProducto(int codigo)
        {
            Producto productoAEditar = _contexto.Producto.FirstOrDefault(producto => producto.codigo == codigo);

            return View("EditarProducto", productoAEditar);
        }
    }
}
