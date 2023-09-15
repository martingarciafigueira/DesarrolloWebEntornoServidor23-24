//Declaramos las variables
int numero1, numero2, suma, resta, multiplicacion;

//Pedimos los numeros al usuario

Console.Write("Introduzca el número 1: ");
numero1 = int.Parse(Console.ReadLine());

Console.Write("Introduzca el número 2: ");
numero2 = int.Parse(Console.ReadLine());

//Realizo los cálculos

suma = numero1 + numero2;

resta = numero1 - numero2;

multiplicacion = numero1 * numero2;

//Muestro los resultados

Console.WriteLine("La suma es: " + suma);
Console.WriteLine("La resta es: " + resta);
Console.WriteLine("La multiplicacion es: " + multiplicacion);

Console.ReadLine();
