int tamanho;

Console.WriteLine("Mete un tamaño de matriz");
tamanho = int.Parse(Console.ReadLine());

int[] matriz = new int[tamanho];

Console.WriteLine("La matriz tiene un tamaño de: " + matriz.Length);

Console.WriteLine("Mete otro tamaño de matriz");
tamanho = int.Parse(Console.ReadLine());

Array.Resize(ref matriz, tamanho);

Console.WriteLine("La matriz tiene un tamaño de: " + matriz.Length);

Console.ReadLine();