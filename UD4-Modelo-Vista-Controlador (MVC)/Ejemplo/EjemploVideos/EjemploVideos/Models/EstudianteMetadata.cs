using System.ComponentModel.DataAnnotations;

namespace EjemploVideos.Models
{
	public class EstudianteMetadata
	{
		[Required]
		public string nombre { get; set; }

		[Required]
		public string apellidos { get; set; }

		[StringLength(9, MinimumLength = 9)]
		public string DNI { get; set; }

		[Range(0, 100)]
		public int edad { get; set; }

		[RegularExpression(@"\w+-\@")]
		public string email { get; set; }

		[Url]
		public string website { get; set; }
	}
}
