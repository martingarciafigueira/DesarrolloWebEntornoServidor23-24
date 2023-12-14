using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CentroPokemon.Models
{
    public class Pokemon
    {
        [Key]
        [Display(Name = "Numero Pokedex")]
        public int PokemonId { get; set; }

        public string nombre { get; set; }

        public double peso { get; set; }

        public double altura { get; set; }

        public virtual ICollection<PokemonTipo> PokemonTipos { get; set; }

    }
}
