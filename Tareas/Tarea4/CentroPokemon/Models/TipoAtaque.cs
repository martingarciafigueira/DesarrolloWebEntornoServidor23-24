using System.ComponentModel.DataAnnotations;

namespace CentroPokemon.Models
{
    public class TipoAtaque
    {
        [Key]
        public int id_tipo_ataque { get; set; }
        public string tipo { get; set; }
    }
}
