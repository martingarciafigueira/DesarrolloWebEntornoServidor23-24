Random rnd = new Random();
int[] valores = new int[100];
double suma = 0;

//Rellenamos el array con los numeros
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = rnd.Next(-10, 11);
}

for (int i = 0; i < valores.Length; i++)
{
    suma += Math.Pow(valores[i], 2);
    Console.Write(valores[i] + ", ");
}
Console.WriteLine();
Console.WriteLine("La suma final de los cuadrados es: " + suma);

Console.ReadLine();