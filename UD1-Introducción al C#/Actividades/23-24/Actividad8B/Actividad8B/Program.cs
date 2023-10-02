using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número");
            int.TryParse(Console.ReadLine(), out int numero);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + numero * i);
            }
            Console.ReadKey();
        }
    }
}
