using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad7A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int numero = int.MinValue;
            bool conversion;

            while (true)
            {
                Console.WriteLine("Introduce un número");

                conversion = int.TryParse(Console.ReadLine(), out numero);

                if (numero == 0 && conversion) break;
                else if (!conversion)
                {
                    Console.WriteLine("Ha fallado la conversión");
                }
                else
                {
                    int i = 1;
                    while (i <= numero)
                    {
                        suma += i;
                        i++;
                    }
                    Console.WriteLine("La suma total es: " + suma);
                    suma = 0;
                }

                Console.ReadKey();
            }
        }
    }
}
