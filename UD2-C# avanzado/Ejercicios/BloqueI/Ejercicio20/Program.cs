using Ejercicio21;
using System;

namespace Ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducimos el tamaño del array y la longitud del password
            Console.WriteLine("Introduce un tamaño para el array");
            String texto = Console.ReadLine();
            int tamanio = int.Parse(texto);

            Console.WriteLine("Introduce la longitud del password");
            texto = Console.ReadLine();
            int longitud = int.Parse(texto);

            //Creamos los arrays
            Password[] listaPassword = new Password[tamanio];
            bool[] fortalezaPassword = new bool[tamanio];

            //Creamos objetos, indicamos si es fuerte y mostramos la contraseña y su fortaleza.
            for (int i = 0; i < listaPassword.Length; i++)
            {
                listaPassword[i] = new Password(longitud);
                fortalezaPassword[i] = listaPassword[i].esFuerte();
                Console.WriteLine(listaPassword[i].getContraseña() + " " + fortalezaPassword[i]);
            }
            Console.ReadKey();
        }
    }
}
