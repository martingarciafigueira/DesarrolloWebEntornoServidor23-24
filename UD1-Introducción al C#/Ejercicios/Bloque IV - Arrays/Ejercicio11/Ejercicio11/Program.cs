Random rnd = new Random();
int[] valores = new int[50];

//Rellenamos el array con los numeros
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = rnd.Next(-10, 51);
}

for (int i = 0; i < valores.Length; i++)
{
	if (valores[i] < 0)
	{
		Console.WriteLine("Valor {0} y posición {1}", valores[i], i);
	}
}

Console.ReadLine();