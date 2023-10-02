namespace ConsolaWeb.Models.Actividad1
{
    public class Libro : Articulo
    {
        private string autor;

        public Libro(string titulo, float precio, string autor) : base(titulo, precio)
        {
            Autor = autor;
        }

        public string Autor { get => autor; set => autor = value; }

        public override string ToString()
        {
            return base.ToString() + " " + Autor;
        }

		public override string generarParrafoConInfo()
		{
			string infoCompleta;
			infoCompleta = "<div>";
			infoCompleta += "<p>Titulo: " + this.titulo + "</p>";
			infoCompleta += "<p>Precio: " + this.precio + "</p>";
			infoCompleta += "<p>Autor: " + this.autor + "</p>";
			infoCompleta += "</div>";

			return infoCompleta;
		}
	}
}
