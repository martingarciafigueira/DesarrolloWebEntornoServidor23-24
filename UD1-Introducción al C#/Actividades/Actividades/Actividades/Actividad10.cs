namespace Actividades
{
    internal class Actividad10
    {
        static void Main(string[] args)
        {
            int tamanho;
            Console.Write("Dime cuántos números quieres ingresar: ");
            int.TryParse(Console.ReadLine(),out tamanho);

            int[] numeros = new int[tamanho];
            int[] numeros2 = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                int num;
                Console.Write("Introduce un número: ");
                int.TryParse(Console.ReadLine(), out num);
                numeros[i] = num;
            }

            Console.WriteLine("Array sin ordenar");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Array ordenado");
            Array.Sort(numeros);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Array ordenado a la inversa");
            Array.Reverse(numeros);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }

            Console.ReadKey();
        }
    }
}