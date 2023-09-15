//Declaramos las variables
double rebaja, precioInicial, porcentajeDescuento, precioFinal;

//Pedimos los datos al usuario
Console.Write("Introduzca el precio inicial del producto: ");
precioInicial = double.Parse(Console.ReadLine());

Console.Write("Introduzca el porcentaje de descuento (%): ");
porcentajeDescuento = double.Parse(Console.ReadLine());

//Realizo los cálculos
rebaja = precioInicial * (porcentajeDescuento / 100);

precioFinal = precioInicial - rebaja;

//Muestro los resultados

Console.WriteLine("Al aplicar un {0} por ciento de descuento el precio final del producto es de {1} euros y por lo tanto se ahorra {2} euros.", porcentajeDescuento, precioFinal, rebaja);

Console.ReadLine();