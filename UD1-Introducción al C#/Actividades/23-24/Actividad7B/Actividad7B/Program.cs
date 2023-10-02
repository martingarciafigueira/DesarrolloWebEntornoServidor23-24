using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad7B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool conversion;
            int numero;
            int suma = 0;

            Console.WriteLine("Introduce un número");

            conversion = int.TryParse(Console.ReadLine(), out numero);

            for (int i = 1; i <= numero; i = i + 2)
            {
                suma += i;
            }
            Console.WriteLine("La suma de los impares hasta ese numero es: " + suma);
            Console.ReadKey();
        }
    }
}
