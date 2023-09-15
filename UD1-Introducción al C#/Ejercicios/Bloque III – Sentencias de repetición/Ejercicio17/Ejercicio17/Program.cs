
int numero, contador = 0;

Console.Write("Introduce un número: ");
numero = int.Parse(Console.ReadLine());

//Contamos la cantidad de divisores de numero
for (int i = 1; i <= numero; i++)
{
	if (numero % i == 0)
	{
		contador++;
	}
}

Console.WriteLine("La cantidad de divisores es: " + contador);

Console.ReadLine();
