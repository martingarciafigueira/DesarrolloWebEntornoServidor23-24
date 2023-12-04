using Ejercicio1.Models;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Ejercicio1.Controllers
{
    public class ProductoController : Controller
    {
        private readonly string connectionString;

        public ProductoController(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("ConexionMontecastelo");
        }
        public IActionResult Index()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var productos = db.Query<Producto>("SELECT * FROM Producto").ToList();
                return View(productos);
            }
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(Producto producto)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Producto (Nombre, Precio) VALUES (@Nombre, @Precio)";
                db.Execute(query, producto);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Producto WHERE Id = @Id";
                var producto = db.QueryFirstOrDefault<Producto>(query, new { Id = id });

                if (producto == null)
                {
                    return NotFound();
                }

                return View(producto);
            }
        }

        [HttpPost]
        public IActionResult Actualizar(Producto producto)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string query = "UPDATE Producto SET Nombre = @Nombre, Precio = @Precio WHERE Id = @Id";
                db.Execute(query, producto);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Detalles(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Producto WHERE Id = @Id";
                var producto = db.QueryFirstOrDefault<Producto>(query, new { Id = id });

                if (producto == null)
                {
                    return NotFound();
                }

                return View(producto);
            }
        }

    }
}
