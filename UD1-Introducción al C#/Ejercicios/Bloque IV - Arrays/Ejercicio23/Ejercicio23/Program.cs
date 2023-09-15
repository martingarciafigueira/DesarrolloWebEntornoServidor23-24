Random rnd = new Random();
int[] valores = new int[100];

//Rellenamos el array con los numeros
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = rnd.Next(500, 2001);
}

//Array.IndexOf(valores, % 2 == 0)

Console.ReadLine();