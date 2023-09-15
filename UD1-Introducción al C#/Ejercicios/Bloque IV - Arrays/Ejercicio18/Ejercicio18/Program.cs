Random rnd = new Random();
string[] valores = new string[10];
int contador = 0;

//Rellenamos el array con los numeros
for (int i = 0; i < valores.Length; i++)
{
    Console.Write("Introduce un string: ");
    valores[i] = Console.ReadLine();
}

for (int i = 0; i < valores.Length; i++)
{
    Console.Write(valores[i] + ", ");
    if (valores[i] == "")
    {
        contador++;
    }
}
Console.WriteLine();
Console.WriteLine("Tenemos {0} posiciones vacías", contador);

Console.ReadLine();