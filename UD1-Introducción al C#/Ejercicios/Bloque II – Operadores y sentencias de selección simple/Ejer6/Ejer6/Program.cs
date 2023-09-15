//Declaro las variables
double numero1, numero2, suma;

//Pido las variables por pantalla
Console.Write("Dame el valor del número 1: ");
numero1 = double.Parse(Console.ReadLine());

Console.Write("Dame el valor del número 2: ");
numero2 = double.Parse(Console.ReadLine());

//Hago los cálculos

suma = numero1 + numero2;

//Hago las comprobaciones
if (suma > 0)
{
    Console.WriteLine("La raíz de {0} es: {1}", suma, Math.Sqrt(suma));
}
else
{
    Console.WriteLine("No se puede calcular la raíz");
}

Console.ReadLine();