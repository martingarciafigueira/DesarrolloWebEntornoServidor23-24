//Declaro las variables
float nota1, nota2, nota3, mediaAritmetica;

//Pido las variables por pantalla
Console.Write("Dame la nota 1: ");
nota1 = float.Parse(Console.ReadLine());

Console.Write("Dame la nota 2: ");
nota2 = float.Parse(Console.ReadLine());

Console.Write("Dame la nota 3: ");
nota3 = float.Parse(Console.ReadLine());

mediaAritmetica = (nota1 + nota2 + nota3) / 3f;

Console.WriteLine("La ´nota media es: {0}", mediaAritmetica);

//Hago las comprobaciones
if (mediaAritmetica >= 5)
{
    Console.WriteLine("Alumno aprobado");
}
else
{
    Console.WriteLine("Alumno suspenso");
}

Console.ReadLine();