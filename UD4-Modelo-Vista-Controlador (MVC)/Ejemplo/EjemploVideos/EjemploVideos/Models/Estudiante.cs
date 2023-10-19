using System.ComponentModel.DataAnnotations;

namespace EjemploVideos.Models
{
	[MetadataType(typeof(EstudianteMetadata))]
	public class Estudiante
	{
		public string nombre { get; set; }
		public string apellidos { get; set; }
		public string DNI { get; set; }
		public int edad { get; set; }
		public string email { get; set; }
		public string website { get; set; }
	}
}
