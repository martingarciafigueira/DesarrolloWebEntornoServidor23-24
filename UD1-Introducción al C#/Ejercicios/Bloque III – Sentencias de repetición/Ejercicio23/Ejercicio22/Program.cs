
int numero, suma = 0;

Console.Write("Introduce número: ");
numero = int.Parse(Console.ReadLine());

//Bucle para comprobar numeros perfectos entre 1 y numero
for (int i = 1; i <= numero; i++)
{
    suma = 0;
    for (int j = 1; j < i; j++)
    {
        if (i % j == 0)
        {
            suma += j;
        }
    }
    if (suma == i)
    {
        Console.WriteLine(i + " es un número perfecto");
    }
}

Console.ReadLine();




