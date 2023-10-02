using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Perecedero : Producto
    {
        //Atributos
        private int dias_a_caducar;

        //Constructores
        public Perecedero(int dias_a_caducar, String nombre, double precio) : base(nombre, precio)
        {
            this.dias_a_caducar = dias_a_caducar;
        }

        //Metodos
        public int getDias_a_caducar()
        {
            return dias_a_caducar;
        }

        public void setDias_a_caducar(int dias_a_caducar)
        {
            this.dias_a_caducar = dias_a_caducar;
        }

        public new String toString()
        {
            return base.toString() + " dias_a_caducar=" + dias_a_caducar;
        }

        /**
         * Calcula el precio segun una cantidad,
         * tambien segun los dias que le queden al prodcuto,
         * se reducira el precio.
         * <ul>
         * <li>1: 4 veces menos</li>
         * <li>2: 3 veces menos</li>
         * <li>3: 2 veces menos</li>
         * </ul>
         * @param cantidad
         * @return 
         */
        public new double calcular(int cantidad)
        {

            double precioFinal = base.calcular(cantidad);

            switch (dias_a_caducar)
            {
                case 1:
                    precioFinal /= 4;
                    break;
                case 2:
                    precioFinal /= 3;
                    break;
                case 3:
                    precioFinal /= 2;
                    break;
            }

            return precioFinal;

        }

    }
}
