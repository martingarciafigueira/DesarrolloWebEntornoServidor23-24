
int numero = -1, suma = 0;

//Se ejecuta el bucle hasta que meto un número positivo
while (numero < 0)
{
    Console.Write("Introduce un número: ");
    numero = int.Parse(Console.ReadLine());
}

//Sumamos todos sus divisores menos el número en concreto
for (int i = 1; i < numero; i++)
{
    if (numero % i == 0)
    {
        suma += i;
    }
}

//Comprobamos si el número es perfecto
if (numero == suma)
{
    Console.WriteLine("El número es perfecto");
}
else
{
    Console.WriteLine("El número no es perfecto");
}

Console.ReadLine();