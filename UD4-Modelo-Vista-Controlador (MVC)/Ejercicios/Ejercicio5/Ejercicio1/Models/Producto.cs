using System.ComponentModel.DataAnnotations;

namespace Ejercicio1.Models
{
    public class Producto
    {
        [Key]
        public int codigo { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int codigo_fabricante { get; set; }
    }
}
