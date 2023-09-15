Random rnd = new Random();
int[] valores = new int[100];
int[] valores2 = new int[100];
bool sonIguales = true;

//Rellenamos el array con los numeros
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = rnd.Next(0, 11);
}
for (int i = 0; i < valores2.Length; i++)
{
    valores2[i] = valores[i];
}

sonIguales = Array.Equals(valores, valores2);

if (sonIguales)
{
    Console.WriteLine("Los arrays son iguales");
}
else
{
    Console.WriteLine("Los arrays no son iguales");
}
Console.ReadLine();