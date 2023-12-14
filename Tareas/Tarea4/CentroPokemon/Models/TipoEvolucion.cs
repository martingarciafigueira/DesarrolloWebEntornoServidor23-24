using System.ComponentModel.DataAnnotations;

namespace CentroPokemon.Models
{
    public class TipoEvolucion
    {
        [Key]
        public int id_tipo_evolucion { get; set; }
        public string tipo_evolucion { get; set; }
    }
}
