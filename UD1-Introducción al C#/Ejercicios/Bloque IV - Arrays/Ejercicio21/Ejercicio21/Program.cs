Random rnd = new Random();
string[] valores = new string[10];

//Rellenamos el array con los numeros
for (int i = 0; i < valores.Length; i++)
{
    Console.Write("Introduce un string: ");
    valores[i] = Console.ReadLine();
}

for (int i = 0; i < valores.Length; i++)
{
    if (valores[i] == "")
    {
        Console.WriteLine("La primera posición vacía es: " + i);
        break;
    }
}

Console.ReadLine();