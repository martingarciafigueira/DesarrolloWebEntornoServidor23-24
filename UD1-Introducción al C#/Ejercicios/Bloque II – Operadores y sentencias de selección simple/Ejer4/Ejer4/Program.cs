//Declaramos las variables
int numero, resto;
bool esPar = false;

//Pedimos el número por pantalla
Console.Write("Dame el número que quieras: ");
numero = int.Parse(Console.ReadLine());

resto = numero % 2;

//FORMA IF: Comprobamos si es par o impar 
if (resto == 0)
{
    Console.WriteLine("El número " + numero + " es par.");
}
else
{
    Console.WriteLine("El número " + numero + " es impar.");
}

//FORMA SWITCH: Comprobamos si es par o impar 
switch (resto)
{
    case 0:
        {
            Console.WriteLine("El número " + numero + " es par.");
            break;
        }
    default:
        {
            Console.WriteLine("El número " + numero + " es impar.");
            break;
        }
}

Console.ReadLine();