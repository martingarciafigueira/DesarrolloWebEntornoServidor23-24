using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porra_2
{
    class Apostador : IApostar
    {
        private string nombre;
        private double dineroTotalApostado;
        private double dineroTotalGanado;
        private int numeroVictorias;

        public Apostador(string nombre, double dineroTotalApostado, double dineroTotalGanado, int numeroVictorias)
        {
            this.Nombre = nombre;
            this.DineroTotalApostado = dineroTotalApostado;
            this.DineroTotalGanado = dineroTotalGanado;
            this.NumeroVictorias = numeroVictorias;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double DineroTotalApostado { get => dineroTotalApostado; set => dineroTotalApostado = value; }
        public double DineroTotalGanado { get => dineroTotalGanado; set => dineroTotalGanado = value; }
        public int NumeroVictorias { get => numeroVictorias; set => numeroVictorias = value; }

        public void apostar(Porra porraSeleccionada, Partido partidoElegido)
        {

            Apuesta nuevaApuesta = new Apuesta(porraSeleccionada, )
        }

        public double recogerDinero()
        {
            double dineroGanado = 0;

            return dineroGanado;
        }
    }
}
