//Declaramos las variables
int a, b, c, d, menor;

//Pedimos los datos por pantalla
Console.Write("Dame los datos de A:");
a = int.Parse(Console.ReadLine());

Console.Write("Dame los datos de B:");
b = int.Parse(Console.ReadLine());

Console.Write("Dame los datos de C:");
c = int.Parse(Console.ReadLine());

Console.Write("Dame los datos de D:");
d = int.Parse(Console.ReadLine());

//Calculamos el menor
if (a > b)
{
    menor = b;
}
else
{
    menor = a;
}

if (menor > c)
{
    menor = c;
}

if (menor > d)
{
    menor = d;
}

Console.Write("El número menor es: " + menor);

Console.ReadLine();