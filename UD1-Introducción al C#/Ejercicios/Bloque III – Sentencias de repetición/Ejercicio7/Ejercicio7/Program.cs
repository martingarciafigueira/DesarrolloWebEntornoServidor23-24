int numero, resultado;

Console.WriteLine("Introduce el número");
numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    resultado = numero * i;
    Console.WriteLine(numero + "x" + i + " = " + resultado);
}

Console.ReadLine();