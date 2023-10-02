using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    class Porra : Constantes
    {
        private double bote;

        public Porra()
        {
            bote = 0;
        }

        /**
         * Aumenta la cantidad del bote
         * @param dinero 
         */
        public void aumentarBote(double dinero)
        {
            bote += dinero;
        }

        /**
         * Dejamos el bote a 0
         */
        public void vacirBote()
        {
            bote = 0;
        }

        /**
         * Metodo principal que simula el transcurso de la porra
         */
        public void jornadas()
        {

            Resultados resultados = new Resultados();
            String[] partidos;

            //Recorremos las jornadas
            for (int i = 0; i < NUMERO_JORNADAS; i++)
            {

                MessageBox.Show("JORNADA " + (i + 1));
                MessageBox.Show("");

                //Apuesta
                for (int j = 0; j < JUGADORES.Length; j++)
                {
                    //Si un jugador puede pagar
                    if (JUGADORES[j].puedePagar())
                    {
                        //el jugador paga, dice sus resultados y el bote se aumenta
                        JUGADORES[j].ponerEnElBote();
                        JUGADORES[j].generarResultados();
                        aumentarBote(DINERO_CADA_JORNADA);
                    }
                    else
                    {
                        //Si no puede pagar, los resultados se vacian
                        JUGADORES[j].reiniciarResultados();
                    }

                }


                //Partido
                resultados.generarResultados();
                partidos = resultados.getPartidos();

                //Comprobacion
                for (int j = 0; j < JUGADORES.Length; j++)
                {
                    //Indica si ha acertado
                    if (JUGADORES[j].haAcertadoPorra(partidos))
                    {
                        //Le damos el bota al jugador y vaciamos el bote
                        JUGADORES[j].ganarBote(bote);
                        vacirBote();
                    }

                }

                MessageBox.Show(toString());

            }

            //Motramos el estado de los jugadores
            for (int i = 0; i < JUGADORES.Length; i++)
            {
                MessageBox.Show(JUGADORES[i].toString());
            }

        }

    public String toString()
        {
            return "En la Porra hay de bote" + bote + " euro/s";
        }
    }
}
