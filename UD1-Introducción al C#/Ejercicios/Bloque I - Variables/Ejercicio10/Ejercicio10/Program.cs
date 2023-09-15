//Creamos las variables
int horasTrabajadas;
float salarioBruto, salarioNeto;

//Definimos las constantes
const float TASA_HORA = 30.5f;
const float IRPF = 0.08f;

//Pedimos por pantalla las horas trabajadas
Console.Write("¿Cuántas horas has currado?: ");
horasTrabajadas = int.Parse(Console.ReadLine());

//Realizamos los cálculos
salarioBruto = TASA_HORA * horasTrabajadas;
salarioNeto = salarioBruto * (1 - IRPF);

//Mostramos los resultados
Console.WriteLine("El salario bruto es: " + salarioBruto);
Console.WriteLine("El salario neto es: " + salarioNeto);

Console.ReadKey();

