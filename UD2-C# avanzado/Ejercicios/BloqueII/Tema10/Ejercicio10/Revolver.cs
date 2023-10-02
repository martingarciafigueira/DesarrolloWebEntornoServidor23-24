using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Revolver
    {

        //Atributos
        private int posicionBalaActual;
        private int posicionBala;

        //Constructor
        public Revolver()
        {
            posicionBalaActual = Metodos.generaNumeroEnteroAleatorio(1, 6);
            posicionBala = Metodos.generaNumeroEnteroAleatorio(1, 6);
        }

        //Metodos

        //Dispara el revolver
        public bool disparar()
        {

            bool exito = false;

            if (posicionBalaActual == posicionBala)
            {
                exito = true; //Alguien va a morir...
            }

            siguienteBala();

            return exito;

        }

        //Cambia a la siguiente posicion
        public void siguienteBala()
        {

            if (posicionBalaActual == 6)
            {
                posicionBalaActual = 1; //posicion incial
            }
            else
            {
                posicionBalaActual++;
            }

        }

        public String toString()
        {
            return "Posicion Bala Actual: " + posicionBalaActual + ", Posicion bala: " + posicionBala;
        }
    }
}
