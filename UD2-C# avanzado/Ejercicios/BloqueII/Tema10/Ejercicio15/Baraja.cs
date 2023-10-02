using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio15
{
    public abstract class Baraja
    {

        //Atributos
        protected Carta<T>[] cartas;
        protected int posSiguienteCarta;
        protected int numCartas;
        protected int cartasPorPalo;

        public Baraja()
        {
            this.posSiguienteCarta = 0;
        }

        /**
         * Metodo abstracto crearBaraja
         */
        public abstract void crearBaraja();

        /**
         * Baraja todas las cartas
         */
        public void barajar()
        {

            int posAleatoria = 0;
            Carta<T> c;

            //Recorro las cartas
            for (int i = 0; i < cartas.Length; i++)
            {

                posAleatoria = Metodos.generaNumeroEnteroAleatorio(0, numCartas - 1);

                //intercambio
                c = cartas[i];
                cartas[i] = cartas[posAleatoria];
                cartas[posAleatoria] = c;

            }

            //La posición vuelve al inicio
            this.posSiguienteCarta = 0;

        }

        /**
         * Devuelve la casta donde se encuentre "posSiguienteCarta"
         *
         * @return carta del arreglo
         */
        public Carta<T> siguienteCarta()
        {

            Carta<T> c = null;

            if (posSiguienteCarta == numCartas)
            {
                MessageBox.Show("Ya no hay mas cartas, barajea de nuevo");
            }
            else
            {
                c = cartas[posSiguienteCarta++];
            }

            return c;

        }

        /**
         * Devuelve un numero de cartas. Controla si hay mas cartas de las que se
         * piden
         *
         * @param numCartas
         * @return
         */
        public Carta<T>[] darCartas(int numCartas)
        {

            if (numCartas > numCartas)
            {
                MessageBox.Show("No se puede dar mas cartas de las que hay");
            }
            else if (cartasDisponible() < numCartas)
            {
                MessageBox.Show("No hay suficientes cartas que mostrar");
            }
            else
            {

                Carta<T>[] cartasDar = new Carta<T>[numCartas];

                //recorro el array que acabo de crear para rellenarlo
                for (int i = 0; i < cartasDar.Length; i++)
                {
                    cartasDar[i] = siguienteCarta(); //uso el metodo anterior
                }

                //Lo devuelvo
                return cartasDar;

            }

            //solo en caso de error
            return null;

        }

        /**
         * Indica el numero de cartas que hay disponibles
         *
         * @return
         */
        public int cartasDisponible()
        {
            return numCartas - posSiguienteCarta;
        }

        /**
         * Muestro las cartas que ya han salido
         */
        public void cartasMonton()
        {

            if (cartasDisponible() == numCartas)
            {
                MessageBox.Show("No se ha sacado ninguna carta");
            }
            else
            {
                //Recorro desde 0 a la posSiguienteCarta
                for (int i = 0; i < posSiguienteCarta; i++)
                {
                    MessageBox.Show(cartas[i].toString());
                }
            }

        }

        /**
         * Muestro las cartas que aun no han salido
         */
        public void mostrarBaraja()
        {

            if (cartasDisponible() == 0)
            {
                MessageBox.Show("No hay cartas que mostrar");
            }
            else
            {
                for (int i = posSiguienteCarta; i < cartas.length; i++)
                {
                    MessageBox.Show(cartas[i].toString());
                }
            }
        }
    }
}
