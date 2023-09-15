short[] array = new short[4];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Mete un valor:");
    array[i] = short.Parse(Console.ReadLine());
}

foreach (short valor in array)
{
    Console.WriteLine(valor);
}

Console.ReadLine();