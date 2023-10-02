namespace Actividades
{
    internal class Actividad8BB
    {
        static void Main(string[] args)
        {
            //Muestra las tabla de multiplicación hasta un número dado
            int numero;
            Console.Write("Introduce un número: ");
            int.TryParse(Console.ReadLine(), out numero);

            for (int i = 1; i <= numero; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                }
            }

            Console.ReadKey();
        }
    }
}