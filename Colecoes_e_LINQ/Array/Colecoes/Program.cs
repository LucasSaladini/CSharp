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