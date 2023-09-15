
int n = -1, suma = 0;

//Se ejecuta el bucle hasta que meto un número positivo
while (n < 0)
{
    Console.Write("Introduce un número: ");
    n = int.Parse(Console.ReadLine());
}

//Calculo la suma de todos los divisores
for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        suma += i;
    }
}

Console.WriteLine("La suma es: " + suma);

Console.ReadLine();

