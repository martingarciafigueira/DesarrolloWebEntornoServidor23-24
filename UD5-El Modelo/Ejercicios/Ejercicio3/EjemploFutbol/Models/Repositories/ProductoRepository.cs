using Dapper;
using Ejercicio3.Models;
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
        public async Task<Producto> GetProducto(int? codigo)
        {
            var query = "SELECT * FROM producto WHERE codigo = @codigo";

            using (var connection = _conexion.ObtenerConexion())
            {
                var producto = await connection.QuerySingleOrDefaultAsync<Producto>(query, new { codigo });
                return producto;
            }
        }
    }
}
