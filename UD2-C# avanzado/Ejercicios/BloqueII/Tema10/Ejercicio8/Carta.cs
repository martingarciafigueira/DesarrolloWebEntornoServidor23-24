using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Carta
    {
        //Atributos
        private int numero;
        private string palo;

        //Constantes
        public static readonly string[] PALOS = { "ESPADAS", "OROS", "COPAS", "BASTOS" };
        public static readonly int LIMITE_CARTA_PALO = 12;

        //Constructor
        public Carta(int numero, String palo)
        {
            this.numero = numero;
            this.palo = palo;
        }

        public String toString()
        {
            return "numero=" + numero + ", palo=" + palo;
        }
    }
}
