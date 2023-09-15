//Declaro las variables
int numero;
bool multiplo2 = false, multiplo3 = false;

//Pido las variables por pantalla
Console.Write("Dame el valor de un número: ");
numero = int.Parse(Console.ReadLine());

//Compruebo si es múltiplo de 2 o de 3
if (numero % 2 == 0)
{
    multiplo2 = true;
}
if (numero % 3 == 0)
{
    multiplo3 = true;
}
if (multiplo2 && multiplo3)
{
    Console.WriteLine("El número {0} es múltiplo de 2 y 3", numero);
}
else if (multiplo2)
{
    Console.WriteLine("El número {0} es múltiplo de 2", numero);
}
else if (multiplo3)
{
    Console.WriteLine("El número {0} es múltiplo de 3", numero);
}

Console.ReadLine();