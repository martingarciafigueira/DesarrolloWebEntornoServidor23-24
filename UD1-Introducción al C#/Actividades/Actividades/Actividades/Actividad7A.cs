namespace Actividades
{
    internal class Actividad7A
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int numero, suma = 0, varControl = 1;
                Console.Write("Introduce un número: ");
                int.TryParse(Console.ReadLine(), out numero);

                if (numero == 0) break;

                while (varControl <= numero)
                {
                    suma += varControl;
                    varControl++;
                }
                Console.WriteLine("La suma desde 1 hasta {0} es: {1}", numero, suma);
                Console.ReadKey();
            }
        }
    }
}