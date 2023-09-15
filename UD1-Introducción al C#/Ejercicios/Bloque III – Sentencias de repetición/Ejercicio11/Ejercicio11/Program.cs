

int n = -1;
double resultado = 0, suma = 0;

//Se ejecuta el bucle hasta que meto un número positivo
while (n < 0)
{
    Console.Write("Introduce un número: ");
    n = int.Parse(Console.ReadLine());
}

for (int i = 1; i <= n; i++)
{
    Console.Write("1 / " + i + "^3");

    resultado = 1 / Math.Pow(i, 3);
    suma += resultado;

    if (i < n)
    {
        Console.Write(" + ");
    }
    else
    {
        Console.Write(" = " + suma);
    }
}
Console.WriteLine();

Console.WriteLine("La suma final es: " + suma);

Console.ReadLine();