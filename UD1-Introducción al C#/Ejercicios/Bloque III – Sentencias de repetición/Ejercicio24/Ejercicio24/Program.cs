

int numeroDado, contadorDivisores = 0, contadorNumerosPrimos = 0;

Console.Write("Introduzca un número: ");
numeroDado = int.Parse(Console.ReadLine()); //Si numeroDado es 5, comprobamos de 1 a 5

for (int numero = 1; numero <= numeroDado; numero++) //Bucle de 1 a 5
{
	for (int divisor = 1; divisor <= numero; divisor++) //Bucle para calcular divisores
	{
		if (numero % divisor == 0)
		{
			contadorDivisores++;
		}
	}
	if (contadorDivisores <= 2)
	{
		contadorNumerosPrimos++;
	}
	contadorDivisores = 0;
}

Console.WriteLine("Hasta el " + numeroDado + " hay " + contadorNumerosPrimos + " números primos");

Console.ReadLine();