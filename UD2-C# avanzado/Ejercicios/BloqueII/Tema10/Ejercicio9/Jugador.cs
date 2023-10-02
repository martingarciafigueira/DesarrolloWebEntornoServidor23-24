using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    class Jugador : Constantes, IMetodosInterfaz
    {
        private String nombre;
        private double dinero;
        private int porrasGanadas;
        private String[] resultados;

        public Jugador(String nombre)
        {
            this.nombre = nombre;
            this.dinero = DINERO_INICIAL;
            this.porrasGanadas = 0;
            this.resultados = new String[NUMERO_PARTIDOS];
            reiniciarResultados();
        }

        public void reiniciarResultados()
        {

            for (int i = 0; i < resultados.Length; i++)
            {
                resultados[i] = "";
            }

        }

        public bool puedePagar()
        {
            return dinero >= DINERO_CADA_JORNADA;
        }

        public void ponerEnElBote()
        {
            dinero -= DINERO_CADA_JORNADA;
            MessageBox.Show("Jugador " + nombre + " ha puesto " + DINERO_CADA_JORNADA + " euro/s y le queda " + dinero + " euro/s");
        }

        public void ganarBote(double bote)
        {
            dinero += bote;
            porrasGanadas++;
            MessageBox.Show("Jugador " + nombre + " ha ganado " + bote + " euro/s y tiene " + dinero + " euro/s");
        }

        public void generarResultados()
        {

            int pLocal, pVisitante;

            for (int i = 0; i < resultados.Length; i++)
            {
                pLocal = Metodos.generaNumeroEnteroAleatorio(RESULTADO_MINIMO, RESULTADO_MAXIMO);
                pVisitante = Metodos.generaNumeroEnteroAleatorio(RESULTADO_MINIMO, RESULTADO_MAXIMO);

                resultados[i] = pLocal + " - " + pVisitante;

                MessageBox.Show("El Jugador " + nombre + " ha elegido el resultado " + resultados[i]);

            }
            MessageBox.Show("");
        }

        public bool haAcertadoPorra(String[] resultados_partidos)
        {

            for (int i = 0; i < resultados.Length; i++)
            {
                if (!resultados[i].Equals(resultados_partidos[i]))
                {
                    return false;
                }
            }
            return true;

        }

        public String toString()
        {
            return "El jugador " + nombre + " tiene dinero=" + dinero + " y ha ganado " + porrasGanadas + " porra/s";
        }
    }
}
