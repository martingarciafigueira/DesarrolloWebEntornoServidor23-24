using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CentroPokemon.Models
{
    public class FormaEvolucion
    {
        [Key]
        public int id_forma_evolucion { get; set; }
        public int tipo_evolucion { get; set; }

        [ForeignKey("TipoEvolucion")]
        public TipoEvolucion TipoEvolucion { get; set; }
    }
}
