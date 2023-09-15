//Declaro las variables
double numero1, numero2;

//Pido las variables por pantalla
Console.Write("Dame el valor del número 1: ");
numero1 = double.Parse(Console.ReadLine());

Console.Write("Dame el valor del número 2: ");
numero2 = double.Parse(Console.ReadLine());

//Hago los cálculos

if (numero1 >= numero2)
{
    Console.WriteLine("El resultado de {0}^{1} es: {2}", numero1, numero2, Math.Pow(numero1, numero2));
}
else
{
    Console.WriteLine("El resultado de {0}^{1} es: {2}", numero2, numero1, Math.Pow(numero2, numero1));
}

Console.ReadLine();