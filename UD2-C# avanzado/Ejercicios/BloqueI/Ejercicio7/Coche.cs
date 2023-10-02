using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    class Coche
    {
        string marca;
        int anhoMatriculacion;
        int capacidad;
        int CV;
        string color;

        public Coche()
        {
        }

        public Coche(string marca, int anhoMatriculacion, int capacidad, int cV, string color)
        {
            this.marca = marca;
            this.anhoMatriculacion = anhoMatriculacion;
            this.capacidad = capacidad;
            this.CV = cV;
            this.color = color;
        }
    }
}
