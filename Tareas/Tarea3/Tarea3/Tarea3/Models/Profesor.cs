using System.ComponentModel.DataAnnotations;

namespace Tarea3.Models {
  public class Profesor {

    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Materia { get; set; }
  }
}
