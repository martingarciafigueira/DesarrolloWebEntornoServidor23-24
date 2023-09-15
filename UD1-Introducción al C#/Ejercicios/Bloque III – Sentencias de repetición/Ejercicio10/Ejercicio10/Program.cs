
int m = -1, suma = 0;

//Se ejecuta el bucle hasta que meto un número positivo
while (m < 0)
{
    Console.Write("Introduce un número: ");
    m = int.Parse(Console.ReadLine());
}

//Calculo la suma de los números hasta m
for (int i = 1; i <= m; i++)
{
    Console.Write(i);
    suma += i;

    if (i < m)
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

