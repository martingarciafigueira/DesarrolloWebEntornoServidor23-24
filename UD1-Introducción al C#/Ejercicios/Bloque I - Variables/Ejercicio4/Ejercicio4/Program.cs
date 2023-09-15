//Creo las variables
double radio, longitud, area, volumen;

//Calculo el valor de radio
Console.Write("Mete un valor para radio:");
radio = double.Parse(Console.ReadLine());

//Realizamos los calculos de longitud, area y volumen
longitud = 2 * Math.PI * radio;
area = Math.PI * Math.Pow(radio, 2);
volumen = (4 / 3) * Math.PI * Math.Pow(radio, 3);

//Muestro los resultados
Console.WriteLine("Los resultados son: ");
Console.WriteLine("Longitud: " + longitud);
Console.WriteLine("Área: " + area);
Console.WriteLine("Volumen: " + volumen);












Console.ReadLine();