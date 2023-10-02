using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio10
{
    class Cuadrado
    {
        int altura;
        int ancho;

        public Cuadrado(int altura, int ancho)
        {
            Altura = altura;
            Ancho = ancho;
        }

        public Cuadrado() { }

        public int Altura
        {
            get => altura;
            set
            {
                if (value >= 0) altura = value;
                else Console.WriteLine("No se puede tener un valor negativo");
            }
        }
        public int Ancho
        {
            get => altura;
            set
            {
                if (value >= 0) ancho = value;
                else Console.WriteLine("No se puede tener un valor negativo");
            }
        }

        public int Area()
        {
            return ancho * altura;
        }

        override
        public string ToString()
        {
            return "La altura es: " + altura + " , el ancho es: " + ancho + " y el área es: " + Area();
        }

    }
}
