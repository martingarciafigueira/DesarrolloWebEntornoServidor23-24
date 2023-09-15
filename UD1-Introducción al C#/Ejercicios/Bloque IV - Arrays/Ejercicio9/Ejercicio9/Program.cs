int numero = 1;
int[] valores = new int[100];

//Rellenamos el array con los numeros
for (int i = 0; i < valores.Length; i++)
{
	if (i % 2 == 0)
	{
		valores[i] = numero;
		numero++;
	}
}

foreach (int valor in valores)
{
	Console.WriteLine(valor);
}

Console.ReadLine();