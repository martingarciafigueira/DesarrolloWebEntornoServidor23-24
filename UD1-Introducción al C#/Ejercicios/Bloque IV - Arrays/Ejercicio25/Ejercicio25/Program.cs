Random rnd = new Random();
int[] valores = new int[100];

//Rellenamos el array con los numeros
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = rnd.Next(-10, 11);
}

Array.Sort(valores);

Console.WriteLine("El mínimo es: " + valores[0]);

Console.ReadLine();
