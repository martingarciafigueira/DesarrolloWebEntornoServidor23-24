namespace ConsolaWeb.Models.Actividad12
{
    public class DVD2 : Publicacion
    {
        private int duracion;

        public DVD2(string titulo, float precio, int duracion)
        {
			this.titulo = titulo;
			this.precio = precio;
			Duracion = duracion;
        }

        public int Duracion { get => duracion; set => duracion = value; }

        public override string ToString()
        {
            return base.ToString() + " " + Duracion;
        }

		public override string mostrarTablaInfoHTML()
		{
			string infoCompleta;
			infoCompleta = "<tr>";
			infoCompleta += "<td>Titulo: " + this.titulo + "</td>";
			infoCompleta += "<td>Precio: " + this.precio + "</td>";
			infoCompleta += "<td>Duracion: " + this.duracion + "</td>";
			infoCompleta += "</tr>";

			return infoCompleta;
		}
	}
}
