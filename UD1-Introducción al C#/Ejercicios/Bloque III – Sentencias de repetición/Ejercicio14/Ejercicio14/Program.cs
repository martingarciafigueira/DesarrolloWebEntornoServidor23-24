
int numero = -1, suma = 0;

//Se ejecuta el bucle hasta que meto un número positivo
while (numero < 0)
{
    Console.Write("Introduce un número: ");
    numero = int.Parse(Console.ReadLine());
}

//Sumamos todos los múltiplos de 5 hasta numero
for (int i = 1; i <= numero; i++)
{
    if (i % 5 == 0)
    {
        suma += i;
    }
}

Console.WriteLine("La suma de los múltiplos de 5 hasta " + numero + " es: " + suma);

Console.ReadLine();