using Dapper;
using EjemploVideos.Models;

namespace EjemploVideos.Repository
{
	public class ProductoRepository : IRepository
	{
		private readonly Conexion _conexion;

		public ProductoRepository(Conexion conexion)
		{
			_conexion = conexion;
		}

		public async Task CreateProducto(Producto producto)
		{
			var query = "INSERT INTO producto (codigo, nombre, codigoFabricante) VALUES (@codigo, @nombre, @codigoFabricante)";

			var parameters = new DynamicParameters();
			parameters.Add("codigo", producto.Id);
			parameters.Add("nombre", producto.Nombre);
			parameters.Add("codigoFabricante", producto.CodigoFabricante);

			using (var connection = _conexion.ObtenerConexion())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}

		public Task DeleteProducto(Producto producto)
		{
			throw new NotImplementedException();
		}

		public async Task<Producto> GetProducto(int? codigoProducto)
		{
			var query = "SELECT * FROM productos WHERE codigoProducto = codigoProducto";

			using (var connection = _conexion.ObtenerConexion())
			{
				var producto = await connection.QuerySingleOrDefaultAsync<Producto>(query, new { codigoProducto });
				return producto;
			}
		}

		public async Task<IEnumerable<Producto>> GetProductos()
		{
			var query = "SELECT * FROM productos";

			using (var connection = _conexion.ObtenerConexion())
			{
				var productos = await connection.QueryAsync<Producto>(query);
				return productos.ToList();
			}
		}

		public Task UpdateProducto(Producto producto)
		{
			throw new NotImplementedException();
		}
	}
}
