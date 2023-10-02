using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Dado
    {
        int valor;

        public Dado()
        {
            valor = 0;
        }

        public Dado(int valor)
        {
            this.Valor = valor;
        }

        public void incrementar()
        {
            if (valor >= 6 )
            {
                valor = 1;
            }
            else
            {
                this.valor++;
            }
        }

        public void valorNuevo()
        {
            Random generador = new Random();
            valor = generador.Next(1, 7);
        }

        public int Valor { get => valor; set => valor = value; }
    }
}
