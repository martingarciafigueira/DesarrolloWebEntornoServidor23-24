using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Lavadora : Electrodomestico
    {
        //Constantes

        /**
         * Carga por defecto
         */
        private readonly static int CARGA_DEF = 5;

        //Atributos

        /**
         * Carga de la lavadora
         */
        private int carga;

        //Métodos publicos

        /**
         * Devuelve la carga de la lavadora
         * @return
         */
        public int getCarga()
        {
            return carga;
        }

        /**
         * Precio final de la lavadora
         * @return precio final de la lavadora
         */
        public new double precioFinal()
        {
            //Invocamos el método precioFinal del método padre
            double plus = base.precioFinal();

            //añadimos el código necesario
            if (carga > 30)
            {
                plus += 50;
            }

            return plus;
        }

        //Constructor

        /**
         * Contructor por defecto
         */
        public Lavadora() : this(PRECIO_BASE_DEF, PESO_DEF, CONSUMO_ENERGETICO_DEF, COLOR_DEF, CARGA_DEF)
        {
        }

        /**
         * Constructor con 2 parametros
         * @param precioBase
         * @param peso
         */
        public Lavadora(double precioBase, double peso) : this(precioBase, peso, CONSUMO_ENERGETICO_DEF, COLOR_DEF, CARGA_DEF)
        {
        }

        /**
         * Constructor con 5 parametros
         * @param precioBase
         * @param peso
         * @param consumoEnergetico
         * @param color
         * @param carga
         */
        public Lavadora(double precioBase, double peso, char consumoEnergetico, String color, int carga) : base(precioBase, peso, consumoEnergetico, color)
        {
            this.carga = carga;
        }

        public override string ToString()
        {
            return "LAVADORA";
        }
    }
}
