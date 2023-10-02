using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    class Globo
    {
        private int x = 50;
        private int y = 50;
        private int diametro = 20;
        private string color = "Blanco";

        public Globo(int x, int y, int diametro, string color)
        {
            this.X = x;
            this.Y = y;
            this.Diametro = diametro;
            this.Color = color;
        }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Diametro { get => diametro; set => diametro = value; }
        public string Color { get => color; set => color = value; }
    }
}
