namespace Actividades
{
    internal class Actividad7C
    {
        static void Main(string[] args)
        {
            int numero, factorial;
            do
            {
                factorial = 1;
                Console.Write("Introduce un número: ");
                int.TryParse(Console.ReadLine(), out numero);

                if (numero < 0) break;

                for (int i = numero; i >= 1; i--)
                {
                    factorial *= i;
                }

                Console.WriteLine("El factorial de {0} es: {1}", numero, factorial);
                Console.ReadKey();

            } while (numero >= 0);

        }
    }
}