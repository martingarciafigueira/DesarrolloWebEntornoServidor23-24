using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Metodos
    {
        public static int generaNumeroEnteroAleatorio(int minimo, int maximo)
        {
            Random generadorAleatorio = new Random();
            int num = generadorAleatorio.Next(minimo, maximo + 1);
            return num;
        }
    }
}
