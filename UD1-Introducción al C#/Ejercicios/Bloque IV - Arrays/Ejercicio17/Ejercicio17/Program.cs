Random rnd = new Random();
int[] valores = new int[100];
float contador = 0;
float porcentaje;

//Rellenamos el array con los numeros
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = rnd.Next(-10, 11);
}

for (int i = 0; i < valores.Length; i++)
{
    Console.Write(valores[i] + ", ");
    if (valores[i] % 2 != 0)
    {
        contador++;
    }
}
Console.WriteLine();
porcentaje = (contador / valores.Length) * 100f;
Console.WriteLine("El % de números impares es: " + porcentaje);

Console.ReadLine();