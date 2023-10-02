namespace Actividades
{
    internal class Actividad7B
    {
        static void Main(string[] args)
        {
            int numero, suma = 0;
            Console.Write("Introduce un número: ");
            int.TryParse(Console.ReadLine(), out numero);

            for (int i = 1; i <= numero; i = i + 2)
            {
                suma += i;
            }
            Console.WriteLine("La suma de los números impares desde 1 hasta {0} es: {1}", numero, suma);
            Console.ReadKey();
        }
    }
}