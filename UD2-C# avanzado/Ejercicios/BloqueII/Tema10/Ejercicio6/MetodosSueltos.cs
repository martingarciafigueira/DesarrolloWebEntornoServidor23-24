using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class MetodosSueltos
    {
        public static int generaNumeroAleatorio(int minimo, int maximo)
        {
            int num;
            Random generador = new Random();
            num = generador.Next(minimo, maximo + 1);
            return num;
        }
    }
}
