using Dapper;
using EjemploFabricante.Models;
using Ejercicio1.Models;
using System.Data;

namespace EjemploFutbol.Models.Repositories
{
    public class FabricanteRepository : IFabricanteRepository
    {
        private readonly Conexion _conexion;

        public FabricanteRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<IEnumerable<Fabricante>> GetFabricantes()
        {
            var query = "SELECT * FROM fabricante";

            using (var connection = _conexion.ObtenerConexion())
            {
                var companies = await connection.QueryAsync<Fabricante>(query);
                return companies.ToList();
            }
        }

        public async Task<Fabricante> GetFabricante(int? codigo)
        {
            var query = "SELECT * FROM fabricante WHERE codigo = @codigo";

            using (var connection = _conexion.ObtenerConexion())
            {
                var Fabricante = await connection.QuerySingleOrDefaultAsync<Fabricante>(query, new { codigo });
                return Fabricante;
            }
        }

        public async Task CreateFabricante(Fabricante Fabricante)
        {
            var query = "INSERT INTO fabricante (codigo, nombre) VALUES (@codigo, @nombre)";

            var parameters = new DynamicParameters();
            parameters.Add("codigo", Fabricante.codigo, DbType.Int32);
            parameters.Add("nombre", Fabricante.nombre, DbType.String);

            using (var connection = _conexion.ObtenerConexion())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task UpdateFabricante(Fabricante Fabricante)
        {
            var query = "UPDATE fabricante SET nombre = @nombre WHERE codigo = @codigo";
            var parameters = new DynamicParameters();
            parameters.Add("nombre", Fabricante.nombre, DbType.String);
            parameters.Add("codigo", Fabricante.codigo, DbType.Int32);
            using (var connection = _conexion.ObtenerConexion())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteFabricante(Fabricante Fabricante)
        {
            var query = "DELETE FROM fabricante WHERE codigo = @codigo";
            using (var connection = _conexion.ObtenerConexion())
            {
                await connection.ExecuteAsync(query, new { Fabricante.codigo });
            }
        }
    }
}
