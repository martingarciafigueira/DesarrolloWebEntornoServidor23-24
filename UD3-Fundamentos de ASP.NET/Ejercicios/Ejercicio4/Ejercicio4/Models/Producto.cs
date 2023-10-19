namespace Ejercicio3.Models
{
	public class Producto
	{
        public Producto(string nombre, float precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public string Nombre { get; set; }

		public float Precio { get; set; }
    }
}
