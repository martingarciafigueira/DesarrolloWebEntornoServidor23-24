using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porra_2
{
    class ApuestaFutbol : Apostable
    {
        private Porra nombrePorra;
        private (Tuple<Equipo, int> golesEquipo1, Tuple<Equipo, int> golesEquipo2) resultado;
        private double dineroApostado;
        private Apostador apostador;

        public ApuestaFutbol(DateTime fecha, string nombreApuesta, Porra nombrePorra, (Tuple<Equipo, int> golesEquipo1, Tuple<Equipo, int> golesEquipo2) resultado, double dineroApostado, Apostador apostador) : base(fecha, TipoPremio.bote, nombreApuesta)
        {
            this.nombrePorra = nombrePorra;
            this.resultado = resultado;
            this.dineroApostado = dineroApostado;
            this.apostador = apostador;
        }

        public double DineroApostado { get => dineroApostado; set => dineroApostado = value; }
        internal Porra NombrePorra { get => nombrePorra; set => nombrePorra = value; }
        internal (Tuple<Equipo, int> golesEquipo1, Tuple<Equipo, int> golesEquipo2) Resultado { get => resultado; set => resultado = value; }
        internal Apostador Apostador { get => apostador; set => apostador = value; }
    }
}
