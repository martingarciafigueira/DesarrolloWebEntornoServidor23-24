
int numero;

Console.WriteLine("Introduce un número");
numero = int.Parse(Console.ReadLine());

for (int i = numero; i < numero + 5; i++)
{
    Console.WriteLine(i + " " + Math.Pow(i, 2) + " " + Math.Pow(i, 3));
}

Console.ReadLine();