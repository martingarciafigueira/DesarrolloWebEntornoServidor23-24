using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio13
{
    class Almacen
    {

        //Atributos
        private Bebida[,] estanteria;

        //Constructores
        public Almacen(int filas, int columnas)
        {
            estanteria = new Bebida[filas, columnas];
        }

        public Almacen()
        {
            estanteria = new Bebida[5, 5];
        }

        //Metodos

        /**
         * Agega una bebida, primera posicion que encuentre
         * @param b 
         */
        public void agregarBebida(Bebida b)
        {

            bool encontrado = false;
            for (int i = 0; i < estanteria.GetLength(0) && !encontrado; i++)
            {
                for (int j = 0; j < estanteria.GetLength(1) && !encontrado; j++)
                {
                    if (estanteria[i, j] == null)
                    {
                        estanteria[i, j] = b; //inserto la bebida
                        encontrado = true; //Salgo
                    }
                }
            }

            //Indico si se ha añadiddo la bebida o no
            if (encontrado)
            {
                MessageBox.Show("Bebida añadida");
            }
            else
            {
                MessageBox.Show("No se ha podido añadir la bebida");
            }

        }

        /**
         * Elimina la bebida con el id que le pasen, sino esta se indica
         * @param id 
         */
        public void eliminarBebida(int id)
        {

            bool encontrado = false;
            for (int i = 0; i < estanteria.GetLength(0) && !encontrado; i++)
            {
                for (int j = 0; j < estanteria.GetLength(1) && !encontrado; j++)
                {
                    if (estanteria[i, j] != null)
                    {
                        if (estanteria[i, j].getId() == id)
                        {
                            estanteria[i, j] = null; //Elimino la bebida
                            encontrado = true; //Salgo
                        }
                    }
                }
            }

            //Indico si se ha eliminado
            if (encontrado)
            {
                MessageBox.Show("Bebida eliminada");
            }
            else
            {
                MessageBox.Show("No existe la bebida");
            }

        }

        /**
         * Recorro las estantenrias y muestro las bebidas
         */
        public void mostrarBebidas()
        {
            for (int i = 0; i < estanteria.GetLength(0); i++)
            {
                for (int j = 0; j < estanteria.GetLength(1); j++)
                {
                    if (estanteria[i, j] != null)
                    {//controlo nulos
                        MessageBox.Show("fila " + i + ", columna: " + j + " Bebida: " + estanteria[i, j].toString());
                    }
                }
            }

        }

        /**
         * Calculo el precio de todas las bebidas
         * @return 
         */
        public double calcularPrecioBebidas()
        {

            double precioTotal = 0;
            for (int i = 0; i < estanteria.GetLength(0); i++)
            {
                for (int j = 0; j < estanteria.GetLength(1); j++)
                {
                    if (estanteria[i, j] != null)
                    {//controlo nulos
                        precioTotal += estanteria[i, j].getPrecio();//acumulo el precio
                    }
                }
            }

            return precioTotal;

        }

        /**
         * Calculo el precio de todas las bebidas dde una marca
         * @param marca
         * @return 
         */
        public double calcularPrecioBebidas(String marca)
        {

            double precioTotal = 0;
            for (int i = 0; i < estanteria.GetLength(0); i++)
            {
                for (int j = 0; j < estanteria.GetLength(1); j++)
                {
                    if (estanteria[i, j] != null)
                    {//controlo nulos

                        if (estanteria[i, j].getMarca().Equals(marca))
                        {
                            precioTotal += estanteria[i, j].getPrecio(); //acumulo el precio
                        }

                    }
                }

            }

            return precioTotal;
        }

        /**
         * Calculo el precio de todas las bebidas de una determinada columna
         * @param columna
         * @return 
         */
        public double calcularPrecioBebidas(int columna)
        {

            double precioTotal = 0;
            if (columna >= 0 && columna < estanteria.GetLength(1))
            {
                for (int i = 0; i < estanteria.GetLength(0); i++)
                {
                    if (estanteria[i, columna] != null)
                    { //controlo nulos
                        precioTotal += estanteria[i, columna].getPrecio(); //acumulo el precio
                    }

                }

            }
            else
            {
                MessageBox.Show("La columna debe estar entre 0 y " + estanteria.Length);
            }

            return precioTotal;

        }
    }
}
