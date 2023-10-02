using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Electrodomestico
    {
        //Constantes

        /**
         * Color por defecto
         */
        protected readonly static String COLOR_DEF = "blanco";

        /**
         * Consumo energetico por defecto
         */
        protected readonly static char CONSUMO_ENERGETICO_DEF = 'F';

        /**
         * Precio base por defecto
         */
        protected readonly static double PRECIO_BASE_DEF = 100;

        /**
         * Peso por defecto
         */
        protected readonly static double PESO_DEF = 5;

        //Atributos

        /**
         * El precio base del electrodomestico
         */
        protected double precioBase;

        /**
         * Color del electrodomestico
         */
        protected String color;

        /**
         * Indica el consumo energetico del electrodomestico
         */
        protected char consumoEnergetico;

        /**
         * Peso del electrodomestico
         */
        protected double peso;

        //Métodos privados

        private void comprobarColor(String color)
        {

            //Colores disponibles
            string[] colores = { "blanco", "negro", "rojo", "azul", "gris" };
            bool encontrado = false;

            for (int i = 0; i < colores.Length && !encontrado; i++)
            {

                if (colores[i].Equals(color))
                {
                    encontrado = true;
                }

            }

            if (encontrado)
            {
                this.color = color;
            }
            else
            {
                this.color = COLOR_DEF;
            }


        }

        /**
         * Comprueba el consumo energetico
         * Solo mayusculas, si es una 'a' no lo detecta como una 'A'
         * @param consumoEnergetico
         */
        public void comprobarConsumoEnergetico(char consumoEnergetico)
        {

            if (consumoEnergetico >= 65 && consumoEnergetico <= 70)
            {
                this.consumoEnergetico = consumoEnergetico;
            }
            else
            {
                this.consumoEnergetico = CONSUMO_ENERGETICO_DEF;
            }

        }

        //Métodos publicos
        /**
         * Devuelve el precio base del electrodomestico
         * @return precio base del electrodomestico
         */
        public double getPrecioBase()
        {
            return precioBase;
        }
        /**
         * Devuelve el color del electrodomestico
         * @return color del elesctrodomestico
         */
        public String getColor()
        {
            return color;
        }

        /**
        * Devuelve el consumo energetico del electrodomestico
        * @return consumo energetico del electrodomestico
        */
        public char getConsumoEnergetico()
        {
            return consumoEnergetico;
        }
        /**
         * Devuelve el peso del electrodomestico
         * @return peso del electrodomestico
         */
        public double getPeso()
        {
            return peso;
        }
        /**
         * Precio final del electrodomestico
         * @return precio final del electrodomestico
         */
        public double precioFinal()
        {
            double plus = 0;
            switch (consumoEnergetico)
            {
                case 'A':
                    plus += 100;
                    break;
                case 'B':
                    plus += 80;
                    break;
                case 'C':
                    plus += 60;
                    break;
                case 'D':
                    plus += 50;
                    break;
                case 'E':
                    plus += 30;
                    break;
                case 'F':
                    plus += 10;
                    break;
            }

            if (peso >= 0 && peso < 19)
            {
                plus += 10;
            }
            else if (peso >= 20 && peso < 49)
            {
                plus += 50;
            }
            else if (peso >= 50 && peso <= 79)
            {
                plus += 80;
            }
            else if (peso >= 80)
            {
                plus += 100;
            }

            return precioBase + plus;
        }

        //Constructores

        /**
         * Contructor por defecto
         */
        public Electrodomestico() : this(PRECIO_BASE_DEF, PESO_DEF, CONSUMO_ENERGETICO_DEF, COLOR_DEF)
        {
        }

        /**
         * Contructor con 2 parametros
         * @param precioBase del electrodomestico
         * @param peso del electrodomestico
         */
        public Electrodomestico(double precioBase, double peso) : this(precioBase, peso, CONSUMO_ENERGETICO_DEF, COLOR_DEF)
        {
        }

        /**
         * Constructor con 4 parametros
         * @param precioBase
         * @param peso
         * @param consumoEnergetico
         * @param color
         */
        public Electrodomestico(double precioBase, double peso, char consumoEnergetico, String color)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            comprobarConsumoEnergetico(consumoEnergetico);
            comprobarColor(color);
        }

    }
}
