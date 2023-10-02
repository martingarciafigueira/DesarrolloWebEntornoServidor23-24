using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Generador
    {
        static int numeroGenerado = 0;

        public Generador()
        {
        }

        public static int GenerarNumero()
        {
            Random nuevo = new Random(numeroGenerado);
            numeroGenerado = nuevo.Next();
            return numeroGenerado;
        }
    }
}
