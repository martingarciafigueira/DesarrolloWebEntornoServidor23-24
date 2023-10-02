namespace Actividades
{
    internal class Actividad8B
    {
        static void Main(string[] args)
        {
            //Muestra la tabla de multiplicación de un número
            int numero;
            Console.Write("Introduce un número: ");
            int.TryParse(Console.ReadLine(), out numero);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
            }
            Console.ReadKey();
        }
    }
}