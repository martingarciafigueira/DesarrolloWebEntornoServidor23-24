namespace ConsolaWeb.Models.Actividad12
{
    public class Libro2 : Publicacion
    {
        private string autor;

        public Libro2(string titulo, float precio, string autor)
        {
			this.titulo = titulo;
			this.precio = precio;
			Autor = autor;
        }

        public string Autor { get => autor; set => autor = value; }

        public override string ToString()
        {
            return base.ToString() + " " + Autor;
        }

		public override string mostrarTablaInfoHTML()
		{
			string infoCompleta;
			infoCompleta = "<tr>";
			infoCompleta += "<td>Titulo: " + this.titulo + "</td>";
			infoCompleta += "<td>Precio: " + this.precio + "</td>";
			infoCompleta += "<td>Autor: " + this.autor + "</td>";
			infoCompleta += "</tr>";

			return infoCompleta;
		}
	}
}
