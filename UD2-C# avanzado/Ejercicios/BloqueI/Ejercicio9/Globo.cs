using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Globo
    {
        private int x = 50;
        private int y = 50;
        private int diametro = 20;
        private string color = "Blanco";

        public void MoverArriba(int distancia)
        {
            this.y += distancia;
        }

        public void CambiarColor(string color)
        {
            this.color = color;
        }

        public void Mostrar()
        {
            Console.WriteLine("Es un globo de color " + this.color);
        }

        public int Y { get => y; }

        public Globo(int diametro)
        {
            this.diametro = diametro;
        }
    }
}
