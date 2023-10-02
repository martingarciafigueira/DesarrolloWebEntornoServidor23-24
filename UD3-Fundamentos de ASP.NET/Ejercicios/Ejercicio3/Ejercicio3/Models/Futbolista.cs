namespace Ejercicio3.Models
{
	public class Futbolista
	{
        public Futbolista(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public string Nombre { get; set; }

		public string Apellido { get; set; }

		public int Edad { get; set; }
    }
}
