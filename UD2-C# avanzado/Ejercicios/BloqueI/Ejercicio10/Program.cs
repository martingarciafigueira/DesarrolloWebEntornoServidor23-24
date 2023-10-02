using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado forma1 = new Cuadrado();
            forma1.Altura = 20;
            forma1.Ancho = 30;
            forma1.Area();
            Console.WriteLine(forma1.ToString());

            Console.ReadKey();

        }
    }
}
