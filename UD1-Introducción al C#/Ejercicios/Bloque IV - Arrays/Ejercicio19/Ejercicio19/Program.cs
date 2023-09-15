Random rnd = new Random();
int[] valores = new int[100];
int contador = 0;

//Rellenamos el array con los numeros
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = rnd.Next(500, 2001);
}

for (int i = 0; i < valores.Length; i++)
{
    if (valores[i] > 1000)
    {
        contador++;
        Console.Write(valores[i] + ", ");
    }
}
Console.WriteLine();
Console.WriteLine("Tenemos {0} valores superiores a 1000", contador);

Console.ReadLine();