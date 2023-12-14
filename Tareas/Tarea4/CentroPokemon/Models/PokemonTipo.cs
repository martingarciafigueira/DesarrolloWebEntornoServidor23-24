using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CentroPokemon.Models
{
    public class PokemonTipo
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Pokemon")]
        [Display(Name = "Numero Pokedex")]
        public int PokemonId { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Tipo")]
        [Display(Name = "ID Tipo")]
        public int id_tipo { get; set; }

        public Pokemon Pokemon { get; set; }
        public Tipo Tipo { get; set; }
    }
}
