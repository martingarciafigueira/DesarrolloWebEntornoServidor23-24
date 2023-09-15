string[] array = new string[5];

//Metemos los 5 libros
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Mete un libro:");
    array[i] = Console.ReadLine();
}

//Mostramos los libros
foreach (string libro in array)
{
    Console.WriteLine(libro);
}

Console.ReadLine();