using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CentroPokemon.Models
{
    public class EvolucionDe
    {
        [Key]
        public int pokemon_evolucionado { get; set; }
        [Key]
        public int pokemon_origen { get; set; }

        [ForeignKey("PokemonEvolucionado")]
        public Pokemon PokemonEvolucionado { get; set; }

        [ForeignKey("PokemonOrigen")]
        public Pokemon PokemonOrigen { get; set; }
    }
}