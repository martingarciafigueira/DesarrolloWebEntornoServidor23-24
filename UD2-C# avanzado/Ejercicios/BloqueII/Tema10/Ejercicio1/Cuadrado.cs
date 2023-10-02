using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Cuadrado
    {
        protected int altura;
        protected int ancho;

        public Cuadrado(int altura, int ancho)
        {
            this.altura = altura;
            this.ancho = ancho;
        }

        public int Area()
        {
            int area;
            area = altura * ancho;
            return area;
        }
    }
}
