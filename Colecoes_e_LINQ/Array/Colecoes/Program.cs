int[] arrayInteiros = new int[3];

arrayInteiros[0] = 10;
arrayInteiros[1] = 20;
arrayInteiros[2] = 30;

Console.WriteLine("Percorrendo o array pelo for");

for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine(arrayInteiros[i]);
}

Console.WriteLine("Percorrendo o array pelo foreach");

foreach (var item in arrayInteiros)
{
    Console.WriteLine(item);
}

// Array Multidimensional
    // array com 4 linhas e 2 colunas
int[,] matriz = new int[4,2]
{
    { 8, 8 },
    { 10, 20 },
    { 50, 100 },
    { 90, 200 }
};

Console.WriteLine("Percorrendo o array multidimensional");

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.WriteLine(matriz[i, j]);
    }
}