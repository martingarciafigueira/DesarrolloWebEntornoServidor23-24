using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    class Raices
    {
        /*Atributos*/
        private double a;
        private double b;
        private double c;

        /**
         * Ecuacion de 2º grado
         * @param a
         * @param b
         * @param c 
         */
        public Raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /**
         * Metodos para obtener las raices cuando hay 2 soluciones posibles
         */
        private void obtenerRaices()
        {

            double x1 = (-b + Math.Sqrt(getDiscriminante())) / (2 * a);
            double x2 = (-b - Math.Sqrt(getDiscriminante())) / (2 * a);

            MessageBox.Show("Solucion X1: " + x1);
            MessageBox.Show("Solucion X2: " + x2);
        }

        /**
         * Obtiene una unica raiz, cuando solo tiene la posibilidad de er una solucion
         */
        private void obtenerRaiz()
        {

            double x = (-b) / (2 * a);

            MessageBox.Show("Unica solucion: " + x);

        }

        /**
         * Nos devuelve el valor del discriminante,  
         * @return 
         */
        private double getDiscriminante()
        {
            return Math.Pow(b, 2) - (4 * a * c);
        }

        /**
         * Si el discriminante es mayor que 0 tiene mas de una raiz
         * (No hemos puesto >= ya que puede confundirse con una solucion)
         * @return 
         */
        private bool tieneRaices()
        {
            return getDiscriminante() > 0;
        }

        /**
         * Si el discriminante es igual a cero tiene una sola raiz
         * @return 
         */
        private bool tieneRaiz()
        {
            return getDiscriminante() == 0;
        }

        /**
         * Nos permite calcular las raices de una ecuacion de 2º grado
         */
        public void calcular()
        {

            if (tieneRaices())
            {
                obtenerRaices();
            }
            else if (tieneRaiz())
            {
                obtenerRaiz();
            }
            else
            {
                MessageBox.Show("No tiene soluciones");
            }

        }
    }
}
