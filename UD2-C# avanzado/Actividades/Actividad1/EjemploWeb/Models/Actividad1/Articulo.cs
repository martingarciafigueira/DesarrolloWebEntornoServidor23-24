namespace ConsolaWeb.Models.Actividad1
{
    public class Articulo
    {
        protected string titulo;
        protected float precio;

        public Articulo(string titulo, float precio)
        {
            Titulo = titulo;
            Precio = precio;
        }

        public Articulo()
        {
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public float Precio { get => precio; set => precio = value; }

        public override string ToString()
        {
            return Titulo + " " + Precio;
        }

		public virtual string generarParrafoConInfo()
		{
			string infoCompleta;
			infoCompleta = "<div>";
			infoCompleta += "<p>Titulo: " + this.titulo + "</p>";
			infoCompleta += "<p>Precio: " + this.precio + "</p>";
			infoCompleta += "</div>";

			return infoCompleta;
		}
	}
}
