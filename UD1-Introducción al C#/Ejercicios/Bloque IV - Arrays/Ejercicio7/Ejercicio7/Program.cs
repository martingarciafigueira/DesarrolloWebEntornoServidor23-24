int n;
Console.Write("Introduce un tamaño:");
n = int.Parse(Console.ReadLine());

int[] valores = new int[n];

valores[0] = 23;
valores[valores.Length - 1] = 1;

for (int i = 0; i < valores.Length; i++)
{
    Console.WriteLine(valores[i]);
}
Console.ReadLine();