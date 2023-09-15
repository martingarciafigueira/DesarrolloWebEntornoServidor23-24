
int n, m;

Console.Write("Introduce un número: ");
n = int.Parse(Console.ReadLine());

Console.Write("Introduce un número: ");
m = int.Parse(Console.ReadLine());

//Hacemos el bucle entre los dos números
for (int i = Math.Min(n, m); i <= Math.Max(n, m); i++)
{
    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
    {
        Console.WriteLine("El primer múltiplo de 3, 5 y 7 es: " + i);
        break;
    }
}

Console.ReadLine();