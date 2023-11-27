using System.ComponentModel.DataAnnotations;

namespace Ejercicio6.Models
{
	public class ContactForm
	{
		public string Name { get; set; }

		[Required(ErrorMessage = "El campo Correo electrónico es obligatorio.")]
		[EmailAddress(ErrorMessage = "El campo Correo electrónico debe tener un formato válido.")]
		public string Email { get; set; }

		public string Message { get; set; }
	}

}
