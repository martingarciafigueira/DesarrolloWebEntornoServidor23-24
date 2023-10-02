using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número hasta el que quieras mostrar la tabla");
            int.TryParse(Console.ReadLine(), out int numeroTablas);

            for (int i = 1; i <= numeroTablas; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + i * j);
                }
            }
            Console.ReadKey();
        }
    }
}
