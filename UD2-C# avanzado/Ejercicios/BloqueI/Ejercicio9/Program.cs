using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operaciones con globos

            Globo globo1 = new Globo(50);

            globo1.Mostrar();
            globo1.MoverArriba(50);
            globo1.CambiarColor("naranja");
            Console.WriteLine("La propiedad Y del globo es: " + globo1.Y);

            Console.ReadKey();
        }
    }
}
