//Declaramos las variables
double espacio, tiempo, velocidad;

//Pedimos los numeros al usuario

Console.Write("Introduzca el espacio: ");
espacio = double.Parse(Console.ReadLine());

Console.Write("Introduzca el tiempo: ");
tiempo = double.Parse(Console.ReadLine());

//Realizo los cálculos

velocidad = espacio / tiempo;

//Muestro los resultados

Console.WriteLine("La velocidad será de: {0} metros/segundo ", velocidad);

Console.ReadLine();

