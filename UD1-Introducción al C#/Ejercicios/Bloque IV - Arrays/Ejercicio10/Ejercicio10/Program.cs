int[] valores = new int[100];
Random rnd = new Random();

for (int i = 0; i < valores.Length; i++)
{
    if (i % 2 != 0)
    {
        valores[i] = rnd.Next(10, 36);
    }
}

foreach (int valor in valores)
{
    Console.WriteLine(valor);
}

Console.ReadLine();