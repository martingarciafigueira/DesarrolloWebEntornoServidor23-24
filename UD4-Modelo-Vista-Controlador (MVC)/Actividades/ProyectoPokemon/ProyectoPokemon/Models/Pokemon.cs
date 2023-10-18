using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProyectoPokemon.Models
{
    public class Pokemon
    {
        public int PokemonId { get; set; }
        public string nombre { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }
    }
}
