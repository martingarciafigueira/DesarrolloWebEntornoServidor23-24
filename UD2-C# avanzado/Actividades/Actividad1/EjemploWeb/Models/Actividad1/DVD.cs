namespace ConsolaWeb.Models.Actividad1
{
    public class DVD : Articulo
    {
        private int duracion;

        public DVD(string titulo, float precio, int duracion) : base(titulo, precio)
        {
            Duracion = duracion;
        }

        public int Duracion { get => duracion; set => duracion = value; }

        public override string ToString()
        {
            return base.ToString() + " " + Duracion;
        }

		public override string generarParrafoConInfo()
		{
			string infoCompleta;
			infoCompleta = "<div>";
			infoCompleta += "<p>Titulo: " + this.titulo + "</p>";
			infoCompleta += "<p>Precio: " + this.precio + "</p>";
			infoCompleta += "<p>Duracion: " + this.duracion + "</p>";
			infoCompleta += "</div>";

			return infoCompleta;
		}
	}
}
