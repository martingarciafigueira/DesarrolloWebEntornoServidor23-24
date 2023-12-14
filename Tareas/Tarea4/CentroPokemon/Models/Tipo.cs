using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CentroPokemon.Models
{
    public class Tipo
    {
        [Key]
        public int id_tipo { get; set; }
        public string nombre { get; set; }
        public int id_tipo_ataque { get; set; }

        [ForeignKey("id_tipo_ataque")]
        public TipoAtaque TipoAtaque { get; set; }
    }
}
