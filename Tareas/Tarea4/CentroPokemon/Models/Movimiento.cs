using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CentroPokemon.Models
{
    public class Movimiento
    {
        [Key]
        public int id_movimiento { get; set; }
        public string nombre { get; set; }
        public int potencia { get; set; }
        public int precision_mov { get; set; }
        public string descripcion { get; set; }
        public int pp { get; set; }

        [ForeignKey("Tipo")]
        public int id_tipo { get; set; }
        public Tipo Tipo { get; set; } 

        public int prioridad { get; set; }
    }
}
