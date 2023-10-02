using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public class Carta<T>
    {

        //Atributos
        private int numero;
        private T palo;

        public int getNumero()
        {
            return numero;
        }

        public T getPalo()
        {
            return palo;
        }

        //Constructor
        public Carta(int numero, T palo)
        {
            this.numero = numero;
            this.palo = palo;
        }

        public String toString()
        {

            String estado = "";
            String nombreFigura = "";

            if (palo.GetType().Equals("PalosBarajaEspañola"))
            {

                switch (numero)
                {
                    case 1:
                        nombreFigura = "As";
                        break;
                    case 10:
                        nombreFigura = "Sota";
                        break;
                    case 11:
                        nombreFigura = "Caballo";
                        break;
                    case 12:
                        nombreFigura = "Rey";
                        break;
                    default:
                        nombreFigura = numero + "";
                        break;
                }
            }
            else if (palo.GetType().Equals("PalosBarajaFrancesa"))
            {

                switch (numero)
                {
                    case 1:
                        nombreFigura = "As";
                        break;
                    case 11:
                        nombreFigura = "Jota";
                        break;
                    case 12:
                        nombreFigura = "Reina";
                        break;
                    case 13:
                        nombreFigura = "Rey";
                        break;
                    default:
                        nombreFigura = numero + "";
                        break;
                }

            }

            estado = nombreFigura + " de " + palo;

            return estado;

        }

    }
}
