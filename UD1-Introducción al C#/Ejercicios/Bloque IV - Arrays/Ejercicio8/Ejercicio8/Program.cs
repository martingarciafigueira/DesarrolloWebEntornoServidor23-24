
//Creamos el array de 100 posiciones
int[] valores = new int[100];

//Creamos el generador de números aleatorios
Random aleatorio = new Random();

//Guardamos valores entre 0 y 10 en el array
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = aleatorio.Next(0, 11);
}

//Mostramos cada uno de los valores
foreach (int valor in valores)
{
    Console.Write(valor + ", ");
}

/*
for (int i = 0; i < valores.Length; i++)
{
    Console.Write(valores[i] + ", ");
}*/

Console.ReadLine();