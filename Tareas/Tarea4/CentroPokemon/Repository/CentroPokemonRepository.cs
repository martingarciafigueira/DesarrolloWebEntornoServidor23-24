using CentroPokemon.Data;
using CentroPokemon.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace CentroPokemon.Repository
{
    public class CentroPokemonRepository : IDisposable
    {
        private readonly IDbConnection _connection;

        public CentroPokemonRepository(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public IEnumerable<Pokemon> GetAllPokemons()
        {
            return _connection.Query<Pokemon>("SELECT * FROM pokemon ORDER BY PokemonId ASC");
        }

        public IEnumerable<Tipo> GetAllTipos()
        {
            return _connection.Query<Tipo>("SELECT * FROM tipo ORDER BY nombre ASC");
        }

        public IEnumerable<Pokemon> GetPokemonByTipo(string type)
        {
            var query = @"
                SELECT pokemon.* 
                FROM pokemon 
                JOIN pokemon_tipo ON pokemon.PokemonId = pokemon_tipo.PokemonId 
                JOIN tipo ON pokemon_tipo.id_tipo = tipo.id_tipo
                WHERE tipo.nombre = @Type
                ORDER BY pokemon.PokemonId ASC";

            return _connection.Query<Pokemon>(query, new { Type = type });
        }

        public IEnumerable<Pokemon> GetPokemonByPeso(double weight)
        {
            var query = @"
                SELECT * FROM pokemon 
                WHERE peso = @Weight
                ORDER BY PokemonId ASC";

            return _connection.Query<Pokemon>(query, new { Weight = weight });
        }

        public IEnumerable<Pokemon> GetPokemonByAltura(double height)
        {
            var query = @"
                SELECT * FROM pokemon 
                WHERE altura = @Height
                ORDER BY PokemonId ASC";

            return _connection.Query<Pokemon>(query, new { Height = height });
        }

        public Pokemon GetPokemonById(int pokemonId)
        {
            var query = @"
                SELECT *
                FROM pokemon
                WHERE PokemonId = @PokemonId";

            return _connection.QueryFirstOrDefault<Pokemon>(query, new { PokemonId = pokemonId });
        }

        public Tipo GetTipoById(int tipoId)
        {
            var query = @"
        SELECT *
        FROM tipo
        WHERE id_tipo = @TipoId";

            return _connection.QueryFirstOrDefault<Tipo>(query, new { TipoId = tipoId });
        }


        public IEnumerable<Pokemon> GetEvolutions(int pokemonId)
        {
            var query = @"
                SELECT p.*
                FROM pokemon p
                INNER JOIN evoluciona_de e ON p.PokemonId = e.pokemon_evolucionado
                WHERE e.pokemon_origen = @PokemonId";

            return _connection.Query<Pokemon>(query, new { PokemonId = pokemonId });
        }

        public IEnumerable<Pokemon> GetInvolutions(int pokemonId)
        {
            var query = @"
                SELECT p.*
                FROM pokemon p
                INNER JOIN evoluciona_de e ON p.PokemonId = e.pokemon_origen
                WHERE e.pokemon_evolucionado = @PokemonId";

            return _connection.Query<Pokemon>(query, new { PokemonId = pokemonId });
        }

        public IEnumerable<Movimiento> GetMovimientosByPokemonId(int pokemonId)
        {
            var query = @"
                SELECT m.*
                FROM movimiento m
                INNER JOIN pokemon_movimiento_forma pmf ON m.id_movimiento = pmf.id_movimiento
                WHERE pmf.PokemonId = @PokemonId";

            return _connection.Query<Movimiento>(query, new { PokemonId = pokemonId });
        }

        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}
