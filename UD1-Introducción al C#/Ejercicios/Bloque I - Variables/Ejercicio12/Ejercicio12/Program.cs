//Declaramos las variables
double lado, area, perimetro, diagonal;

//Pedimos los datos al usuario
Console.Write("Introduzca el lado de un cuadrado: ");
lado = double.Parse(Console.ReadLine());

//Realizo los cálculos

perimetro = lado * 4;
diagonal = lado * Math.Sqrt(2);
area = Math.Pow(lado, 2);

//Muestro los resultados

Console.WriteLine("El períemtro es de : {0} ", perimetro);
Console.WriteLine("La diagonal es de : {0} ", diagonal);
Console.WriteLine("El área es de : {0} ", area);

Console.ReadLine();

