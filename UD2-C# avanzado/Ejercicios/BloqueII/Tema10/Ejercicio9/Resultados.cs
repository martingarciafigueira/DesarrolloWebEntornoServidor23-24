using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    class Resultados : Constantes, IMetodosInterfaz
    {
        private String[] partidos;

        public Resultados()
        {
            partidos = new String[NUMERO_PARTIDOS];
        }

        /**
         * Genera los resultado del partido
         */
        public void generarResultados()
        {

            int pLocal, pVisitante;

            for (int i = 0; i < partidos.Length; i++)
            {
                //Generamos los resultados
                pLocal = Metodos.generaNumeroEnteroAleatorio(RESULTADO_MINIMO, RESULTADO_MAXIMO);
                pVisitante = Metodos.generaNumeroEnteroAleatorio(RESULTADO_MINIMO, RESULTADO_MAXIMO);

                partidos[i] = pLocal + " - " + pVisitante;

                MessageBox.Show("El partido " + (i + 1) + " ha generado el resultado " + partidos[i]);
            }

        }

        public String[] getPartidos()
        {
            return partidos;
        }
    }
}
