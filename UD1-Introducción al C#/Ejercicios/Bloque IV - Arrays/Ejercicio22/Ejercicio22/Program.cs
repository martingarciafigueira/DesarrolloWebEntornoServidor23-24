Random rnd = new Random();
int[] valores = new int[100];

//Rellenamos el array con los numeros
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = rnd.Next(500, 2001);
}

for (int i = 0; i < valores.Length; i++)
{
    if (valores[i] % 2 == 0)
    {
        Console.Write("El número es: {0} y la posición es: {1}", valores[i], i);
        break;
    }
}
Console.ReadLine();