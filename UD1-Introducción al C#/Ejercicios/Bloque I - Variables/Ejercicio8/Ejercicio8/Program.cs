//Creamos las variables 
double presion, volumen, nMoles, temperatura;

//Definimos la constante
const double R = 0.082;

//Pedimos los datos por teclado
Console.Write("Dame el volumen: ");
volumen = double.Parse(Console.ReadLine());

Console.Write("Dame el número de moles: ");
nMoles = double.Parse(Console.ReadLine());

Console.Write("Dame la temperatura: ");
temperatura = double.Parse(Console.ReadLine());

//Hacemos los calculos: p= nRT/v

presion = (nMoles * R * temperatura) / volumen;

Console.WriteLine("Con un volumen de " + volumen + " litros, y una temperatura de " + temperatura + " kelvin, " + nMoles + " moles de un gas ideal tienen una presión de " + presion + " atmósferas");

Console.ReadKey();  
