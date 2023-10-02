using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100 + 1);
            }

            foreach (int i in array)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            int suma = 0;
            foreach (int i in array)
            {
                suma += i;
            }
            Console.WriteLine("La suma es: " + suma);

            Array.Sort(array);
            Console.WriteLine("El número más pequeño es: " + array[0]);
            Console.WriteLine("El número más grande es: " + array[array.Length - 1]);

            Console.ReadKey();
        }
    }
}
