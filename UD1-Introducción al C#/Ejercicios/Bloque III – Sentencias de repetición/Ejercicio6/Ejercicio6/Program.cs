

int n = 8, resultado;

for (int i = 1; i <= 100; i++)
{
	if (i % 5 == 0)
	{
		Console.WriteLine(i + " es múltiplo de 5");
	}
    if (i % 7 == 0)
    {
        Console.WriteLine(i + " es múltiplo de 7");
    }
}

Console.ReadLine();