using Dapper;
using System.Data;

namespace AppTienda.Models.Repository
{
    public class FabricanteRepository : IFabricanteRepository
    {
        private readonly Conexion _conexion;

        public FabricanteRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public IEnumerable<Fabricante> GetFabricantes()
        {
            var query = "SELECT * FROM fabricante";

            using (var connection = _conexion.ObtenerConexion())
            {
                var fabricantes = connection.Query<Fabricante>(query);
                return fabricantes;
            }
        }
        public Fabricante GetFabricante(int? codigo)
        {
            var query = "SELECT * FROM fabricante WHERE codigo = @codigo";

            using (var connection = _conexion.ObtenerConexion())
            {
                var fabricante = connection.QueryFirst<Fabricante>(query, new { codigo });
                return fabricante;
            }
        }
        public void CreateFabricante(Fabricante fabricante)
        {
            var query = "INSERT INTO fabricante (codigo, nombre) VALUES (@codigo, @nombre)";

            var parameters = new DynamicParameters();
            parameters.Add("codigo", fabricante.Codigo, DbType.Int32);
            parameters.Add("nombre", fabricante.Nombre, DbType.String);

            using (var connection = _conexion.ObtenerConexion())
            {
                connection.Execute(query, parameters);
            }
        }
        public void UpdateFabricante(Fabricante fabricante)
        {
            var query = "UPDATE fabricante SET nombre = @nombre WHERE codigo = @codigo";

            var parameters = new DynamicParameters();
            parameters.Add("codigo", fabricante.Codigo, DbType.Int32);
            parameters.Add("nombre", fabricante.Nombre, DbType.String);

            using (var connection = _conexion.ObtenerConexion())
            {
                connection.Execute(query, parameters);
            }
        }
        public void DeleteFabricante(Fabricante fabricante)
        {
            var query = "DELETE FROM fabricante WHERE codigo = @codigo";

            var parameters = new DynamicParameters();
            parameters.Add("codigo", fabricante.Codigo, DbType.Int32);

            using (var connection = _conexion.ObtenerConexion())
            {
                connection.Execute(query, parameters);
            }
        }
    }
}
