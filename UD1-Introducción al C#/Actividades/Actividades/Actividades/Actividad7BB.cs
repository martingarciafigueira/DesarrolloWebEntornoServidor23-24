namespace Actividades
{
    internal class Actividad7BB
    {
        static void Main(string[] args)
        {
            //Sume todos los números excepto el 5
            int numero, suma = 0; 
            Console.Write("Introduce un número: ");
            int.TryParse(Console.ReadLine(), out numero);

            for (int i = 1; i <= numero; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                suma += i;
            }
            Console.WriteLine("La suma de los números impares desde 1 hasta {0} es: {1}", numero, suma);
            Console.ReadKey();
        }
    }
}