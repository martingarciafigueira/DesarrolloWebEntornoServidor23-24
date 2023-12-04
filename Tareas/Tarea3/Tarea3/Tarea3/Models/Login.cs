using System.ComponentModel.DataAnnotations;

namespace Tarea3.Models {
  public class Login {

    [Key]
    public int Id { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
  }
}
