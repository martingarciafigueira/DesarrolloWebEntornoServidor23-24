using Dapper;
using Ejercicio2.Models;
using Ejercicio1.Models;
using System.Data;

namespace EjemploFutbol.Models.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly Conexion _conexion;

        public ProductoRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<IEnumerable<Producto>> GetProductos()
        {
            var query = "SELECT * FROM producto";

            using (var connection = _conexion.ObtenerConexion())
            {
                var productos = await connection.QueryAsync<Producto>(query);
                return productos.ToList();
            }
        }
    }
}
