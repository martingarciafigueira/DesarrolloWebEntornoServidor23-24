using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porra_2
{
    enum TipoPremio { bote = 0, premioFijo = 1 };
    abstract class Apostable
    {
        private DateTime fecha;
        private TipoPremio tipoPremio;
        private string nombre;

        protected DateTime Fecha { get => fecha; set => fecha = value; }
        protected TipoPremio TipoPremio { get => tipoPremio; set => tipoPremio = value; }
        protected string Nombre { get => nombre; set => nombre = value; }

        protected Apostable(DateTime fecha, TipoPremio tipoPremio, string nombre)
        {
            this.Fecha = fecha;
            this.TipoPremio = tipoPremio;
            this.Nombre = nombre;
        }
    }
}
