using System.ComponentModel.DataAnnotations;

namespace Ejemplo.Models
{
    public class Usuario : IValidatableObject
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string RetypedPassword { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> listaValidaciones = new List<ValidationResult>();
            if (string.IsNullOrWhiteSpace(Username))
            {
                listaValidaciones.Add(new ValidationResult("El usuario no puede estar vacío", new[] { "Username" }));
            }

            if (Password != RetypedPassword)
            {
                listaValidaciones.Add(new ValidationResult("Password inválido", new[] { "Password", "RetypedPassword" }));
            }

            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                listaValidaciones.Add(new ValidationResult("Los Domingos estamos cerrados :) "));
            }
            return listaValidaciones;
        }
    }
}
