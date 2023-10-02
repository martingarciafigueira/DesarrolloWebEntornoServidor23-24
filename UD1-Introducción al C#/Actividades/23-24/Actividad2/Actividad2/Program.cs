using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Introduce el número");
            int.TryParse(Console.ReadLine(), out num1);

            if (num1 == 0)
            {
                Console.WriteLine("Es el numero cero");
            }
            else if (num1 % 2 == 0)
            {
                Console.WriteLine("Es un número par");
            }
            else
            {
                Console.WriteLine("Es un número impar");
            }

            Console.ReadKey();

        }
    }
}
