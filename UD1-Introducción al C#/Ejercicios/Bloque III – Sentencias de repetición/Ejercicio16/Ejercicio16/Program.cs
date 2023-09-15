
int numero, contador = 0;

Console.WriteLine("Introduce un número");
numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    if (i % 3 == 0)
    {
        contador++;
    }
}

Console.WriteLine("La cantidad de múltiplos es: " + contador);

Console.ReadLine();
