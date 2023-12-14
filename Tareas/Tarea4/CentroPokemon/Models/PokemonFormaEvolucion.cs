using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CentroPokemon.Models
{
    public class PokemonFormaEvolucion
    {
        [Key]
        public int PokemonId { get; set; }
        public int id_forma_evolucion { get; set; }

        [ForeignKey("NumeroPokedex")]
        public Pokemon Pokemon { get; set; }

        [ForeignKey("IdFormaEvolucion")]
        public FormaEvolucion FormaEvolucion { get; set; }
    }
}
