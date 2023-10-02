namespace Actividades
{
    internal class Actividad9
    {
        static void Main(string[] args)
        {
            float[] arrayNotas = { 5, 8, 9, 4.6f, 7, 6, 2.9f, 10 };
            float[] arrayNotas2 = new float[8];

            for (int i = 0; i < arrayNotas.Length; i++)
            {
                arrayNotas2[i] = arrayNotas[i];
            }

            int numerosDiferentes = 0;

            for (int i = 0; i < arrayNotas.Length; i++)
            {
                if (arrayNotas2[i] != arrayNotas[i])
                {
                    numerosDiferentes++;
                }
            }
            if (numerosDiferentes > 0)
            {
                Console.WriteLine("Arrays distintos");
            }
            else
            {
                Console.WriteLine("Arrays iguales");
            }

            Console.WriteLine("ARRAY 1: ");
            for (int i = 0; i < arrayNotas.Length; i++)
            {
                Console.Write(arrayNotas[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("ARRAY 2: ");
            for (int i = 0; i < arrayNotas2.Length; i++)
            {
                Console.Write(arrayNotas2[i] + " ");
            }
            Console.ReadKey();
        }
    }
}