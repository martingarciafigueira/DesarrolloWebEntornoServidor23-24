using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Caja : Cuadrado
    {
        protected int profundidad;

        public Caja(int altura, int ancho, int profundidad) : base(altura, ancho)
        {
            this.profundidad = profundidad;
        }

        public int Volumen()
        {
            int volumen;
            volumen = altura * ancho * profundidad;
            return volumen;
        }
    }
}
