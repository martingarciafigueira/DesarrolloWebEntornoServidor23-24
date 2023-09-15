//Declaro las variables
float presion, temperatura;

//Pido las variables por pantalla
Console.Write("Dame la presión de la central nuclear: (atm) ");
presion = float.Parse(Console.ReadLine());

Console.Write("Dame la temperatura de la central nuclear: (Kelvin) ");
temperatura = float.Parse(Console.ReadLine());

Console.WriteLine("MOSTRANDO MENSAJES: ");

//Hago las comprobaciones
if (presion > 2)
{
    Console.WriteLine("Abrir válvula de seguridad!");
}

if (temperatura > 500)
{
    Console.WriteLine("Reducir la temperatura");
}

if (presion <= 2 && temperatura <= 500)
{
    Console.WriteLine("Todo en orden");
}

Console.ReadLine();