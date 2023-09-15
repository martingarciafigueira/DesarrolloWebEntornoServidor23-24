//Declaramos las variables
double ladoA, ladoB, hipotenusa;

//Pedimos los datos al usuario
Console.Write("Introduzca el lado del cateto A: ");
ladoA = double.Parse(Console.ReadLine());
Console.Write("Introduzca el lado del cateto B: ");
ladoB = double.Parse(Console.ReadLine());

//Realizo los cálculos

hipotenusa = Math.Sqrt(Math.Pow(ladoA, 2) + Math.Pow(ladoB, 2));

//Muestro los resultados

Console.WriteLine("La hipotenusa es de : {0} ", hipotenusa);

Console.ReadLine();

