Random rnd = new Random();
int[] valores = new int[100];
int suma = 0;

//Rellenamos el array con los numeros
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = rnd.Next(-10, 11);
}

for (int i = 0; i < valores.Length; i++)
{
    if (i % 2 == 0)
    {
        suma += valores[i];
        Console.Write(valores[i] + ", ");
    }
}
Console.WriteLine();
Console.WriteLine("La suma final es: " + suma);

Console.ReadLine();