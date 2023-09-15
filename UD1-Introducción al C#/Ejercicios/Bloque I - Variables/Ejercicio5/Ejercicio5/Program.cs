//Creamos las variables
double precio;
short cantidad;
double importe_final;

//Pido los datos por pantalla
Console.Write("Introduce el precio del producto: ");
precio = double.Parse(Console.ReadLine());

Console.Write("Introduce la cantidad: ");
cantidad = short.Parse(Console.ReadLine());

//Calculo el importe final
importe_final = precio * cantidad;

//Muestro el resultado por pantalla
Console.WriteLine("El precio del producto es " + precio + " euros y la cantidad que compra es " + cantidad + " y por lo tanto debe pagar " + importe_final + " euros. Vuelva pronto.");

Console.ReadLine();
