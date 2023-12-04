using System.ComponentModel.DataAnnotations;

namespace Tarea3.Models {
  public class Asignatura {

    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
  }
}
