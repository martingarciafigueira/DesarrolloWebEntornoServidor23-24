using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    class Cine
    {
        /*Atributos*/
        private Asiento[,] asientos;
        private double precio;
        private Pelicula pelicula;

        /*Constructor*/
        public Cine(int filas, int columnas, double precio, Pelicula pelicula)
        {
            asientos = new Asiento[filas, columnas];
            this.precio = precio;
            this.pelicula = pelicula;
            rellenaButacas();
        }

        /*Metodos*/
        public Asiento[,] getAsientos()
        {
            return asientos;
        }

        public void setAsientos(Asiento[,] asientos)
        {
            this.asientos = asientos;
        }

        public double getPrecio()
        {
            return precio;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }

        public Pelicula getPelicula()
        {
            return pelicula;
        }

        public void setPelicula(Pelicula pelicula)
        {
            this.pelicula = pelicula;
        }

        /**
         * Rellena nuestros asientos, dandoles una fila y una letra
         */
        private void rellenaButacas()
        {

            int fila = asientos.GetLength(0);
            for (int i = 0; i < asientos.GetLength(0); i++)
            {
                for (int j = 0; j < asientos.GetLength(1); j++)
                {
                    //Recuerda que los char se pueden sumar
                    asientos[i, j] = new Asiento((char)('A' + j), fila);
                }
                fila--; //Decremento la fila para actualizar la fila
            }
        }

        /**
         * Indicamos si hay sitio en el cine, cuando vemos una vacia salimos de la
         * función
         *
         * @return
         */
        public bool haySitio()
        {

            for (int i = 0; i < asientos.GetLength(0); i++)
            {
                for (int j = 0; j < asientos.GetLength(1); j++)
                {
                    if (!asientos[i, j].ocupado())
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /**
         * Indico si en una posicion concreta esta ocupada
         *
         * @param fila
         * @param letra
         * @return
         */
        public bool haySitioButaca(int fila, char letra)
        {
            return ! getAsiento(fila, letra).ocupado();
        }

        /**
         * Indicamos si el espectador cumple lo necesario para entrar: - Tiene
         * dinero - Tiene edad El tema de si hay sitio, se controla en el main
         *
         * @param e
         * @return
         */
        public bool sePuedeSentar(Espectador e)
        {
            return e.tieneDinero(precio) && e.tieneEdad(pelicula.getEdadMinima());
        }

        /**
         * Siento al espectador en un asiento
         *
         * @param fila
         * @param letra
         * @param e
         */
        public bool sentar(int fila, char letra, Espectador e)
        {
            getAsiento(fila, letra).setEspectador(e);
            return true;
        }

        /**
         * Devuelvo un asiento concreto por su fila y letra
         *
         * @param fila
         * @param letra
         * @return
         */
        public Asiento getAsiento(int fila, char letra)
        {
            return asientos[fila, letra - 'A'];
        }

        /**
         * Numero de filas de nuestro cine
         *
         * @return
         */
        public int getFilas()
        {
            return asientos.GetLength(0);
        }

        /**
         * Numero de columas de nuestro cine
         *
         * @return
         */
        public int getColumnas()
        {
            return asientos.GetLength(1);
        }

        /**
         * Mostramos la información de nuestro cine (Tambien se puede hacer en un
         * toString pero hay que devolver un String)
         */
        public void mostrar()
        {

            MessageBox.Show("Información cine");
            MessageBox.Show("Pelicula reproducida: " + pelicula);
            MessageBox.Show("Precio entrada: " + precio);
            for (int i = 0; i < asientos.GetLength(0); i++)
            {
                for (int j = 0; j < asientos.GetLength(1); j++)
                {
                    MessageBox.Show(asientos[i,j].toString());
                }
            }
        }
    }
}
