//Creamos dos variables numericas
int x, y, aux;

//Introducimos el valor de X
Console.Write("Mete el valor de X: ");
x = int.Parse(Console.ReadLine());
Console.WriteLine("El valor de X es: " + x);

//Introducimos el valor de Y
Console.Write("Mete el valor de Y: ");
y = int.Parse(Console.ReadLine());
Console.WriteLine("El valor de Y es: " + y);

Console.WriteLine("---------------------------------------------");
Console.WriteLine("Intercambiamos los valores de X e Y");

//Intercambiamos los valores
aux = x;
x = y;
y = aux;

//Mostramos los valores intercambiados
Console.WriteLine("El valor de X es: " + x);
Console.WriteLine("El valor de Y es: " + y);

Console.ReadKey();
