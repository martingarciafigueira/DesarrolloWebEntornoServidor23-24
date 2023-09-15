

//Mostrar las filas por pantalla
for (int i = 0; i <= 7; i++)
{
    //Pintar cada fila
    for (int j = 1; j <= 7 - i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//ApartadoB
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

ApartadoC
for (int i = 1; i <= 5; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
for (int i = 5; i >= 1; i--)
{
    for (int j = 1; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//ApartadoD
for (int i = 7; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}

//ApartadoE
int numero = 1;
for (int i = 7; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(numero);
    }
    numero++;
    Console.WriteLine();
}

Console.ReadLine();