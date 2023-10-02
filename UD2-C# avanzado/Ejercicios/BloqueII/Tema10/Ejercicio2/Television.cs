using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Television : Electrodomestico
    {

        //Constantes

        /**
         * Resolucion por defecto
         */
        private readonly static int RESOLUCION_DEF = 20;

        //Atributos

        /**
         * Resolucion del televisor
         */
        private int resolucion;

        /**
         * Indica si tiene o no sintonizadorTDT
         */
        private bool sintonizadorTDT;

        //Métodos publicos

        /**
         * Precio final de la television
         * @return precio final de la television
         */
        public new double precioFinal()
        {
            //Invocamos el método precioFinal del método padre
            double plus = base.precioFinal();

            //Añadimos el codigo necesario
            if (resolucion > 40)
            {
                plus += precioBase * 0.3;
            }
            if (sintonizadorTDT)
            {
                plus += 50;
            }

            return plus;
        }

        //Constructor

        /**
         * Constructor por defecto
         */
        public Television() : this(PRECIO_BASE_DEF, PESO_DEF, CONSUMO_ENERGETICO_DEF, COLOR_DEF, RESOLUCION_DEF, false)
        {
        }

        /**
         * Constructor con 2 parametros
         * @param precioBase
         * @param peso
         */
        public Television(double precioBase, double peso) : this(precioBase, peso, CONSUMO_ENERGETICO_DEF, COLOR_DEF, RESOLUCION_DEF, false)
        {
        }

        /**
         * Contructor con 6 parametros
         * @param precioBase
         * @param peso
         * @param consumoEnergetico
         * @param color
         * @param resolucion
         * @param sintonizadorTDT
         */
        public Television(double precioBase, double peso, char consumoEnergetico, String color, int resolucion, bool sintonizadorTDT): base(precioBase, peso, consumoEnergetico, color)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }

        public override string ToString()
        {
            return "TELEVISIÓN";
        }

    }
}
