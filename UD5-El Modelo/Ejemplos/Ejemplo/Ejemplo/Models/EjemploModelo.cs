using System.ComponentModel.DataAnnotations;

namespace Ejemplo.Models
{
    public class EjemploModelo
    {
        [Required]
        public string Nombre { get; set; } // Empty string are not allowed.

        [Required(ErrorMessage = "The surname is required")]
        public string Apellidos { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "The DNI is required")] // This property will allow spaces
        public string DNI { get; set; }

        [Range(0.0, 300.0)]
        public double Peso { get; set; }

        [Range(0, 23, ErrorMessage = "Between {1} and {2}")]
        public int Hora { get; set; }

        [Range(typeof(DateTime), "1/1/1990", "5/5/2023")]
        public DateTime FechaNacimiento { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email { get; set; }

        [RegularExpression("...", ErrorMessage = "Must match the RegEx{1}")]
        public string Value { get; set; }

        [StringLength(50)] // Max 50 chars
        public string Nombre2 { get; set; }

        [StringLength(9, MinimumLength = 9)]    // Exactly 9 chars length
        public string NumeroTelefono { get; set; }

        [StringLength(50, MinimumLength = 10)]    // Between 10 and 50 chars length
        public string Password { get; set; }

        [Required]
        public string Password2 { get; set; }

        [Required, Compare("Password", ErrorMessage = "Passwords must match")]
        public string PasswordRepetido { get; set; }

        [Required]
        [CreditCard]
        public string TarjetaCredito { get; set; }

        [EmailAddress]
        public string Email2 { get; set; }

        [FileExtensions(Extensions = "png,jpg")]
        public string ImagenPerfil { get; set; }

        [Phone]
        public string NumeroTelefono2 { get; set; }

        [Url]
        public string DireccionWeb { get; set; }

        [CustomValidation(typeof(ValidacionesPersonalizadas), "EsPar")]
        public int EsPar { get; set; }


        [EsPar]
        public int NumeroPar { get; set; }


    }
}
