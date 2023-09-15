//Declarar las variables
string passwordUsuario, passwordGuardado = "jamon";

//Pedimos el dato
Console.Write("Introduce el password: ");
passwordUsuario = Console.ReadLine();

//Comprobamos si el password introducido es correcto
if (passwordUsuario == passwordGuardado)
{
    Console.WriteLine("Contraseñas iguales");
}
else
{
    Console.WriteLine("Contraseñas diferentes");
}

Console.ReadLine();