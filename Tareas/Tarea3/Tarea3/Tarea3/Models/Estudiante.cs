using System.ComponentModel.DataAnnotations;

namespace Tarea3.Models {
  public class Estudiante {

    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Curso { get; set; }
  }
}
