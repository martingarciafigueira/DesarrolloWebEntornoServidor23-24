//Creamos las variables temperaturas
float temperaturaC, temperaturaF;

//Pedimos la temperatura en Celsius por pantalla
Console.Write("Introduce los grados Celsius :");
temperaturaC = float.Parse(Console.ReadLine());

//Calculamos la temperatura en Fahrenheit
temperaturaF = (temperaturaC * 9 / 5) + 32;

//Mostramos la temperatura en grados Fahrenheit
Console.WriteLine(temperaturaC + " grados Celsius son " + temperaturaF +" grados Fahrenheit");

Console.ReadKey();