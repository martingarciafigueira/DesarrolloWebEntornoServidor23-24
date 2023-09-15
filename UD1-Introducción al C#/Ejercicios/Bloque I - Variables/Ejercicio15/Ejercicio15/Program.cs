//Creo las variables
double lado, diametro, volumen, areaLado;

//Pido el lado por pantalla
Console.Write("Dame el lado del cubo: ");
lado = double.Parse(Console.ReadLine());

//Hago los calculos
diametro = Math.Sqrt(3) * lado;
areaLado = 4 * Math.Pow(lado, 2);
volumen = Math.Pow(lado, 3);

//Mostrar los datos
Console.WriteLine();
Console.WriteLine("El lado introducido es: " + lado);
Console.WriteLine("El diámetro del cubo es: " + diametro);
Console.WriteLine("El área de una cara es: " + areaLado);
Console.WriteLine("El volumen es: " + volumen);

Console.ReadKey();