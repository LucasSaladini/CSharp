using System.Collections.Generic;

List<string> estados = new List<string>();

estados.Add("SP");
estados.Add("MG");
estados.Add("BA");

System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

System.Console.WriteLine("--------------");
System.Console.WriteLine("Imprimindo através do foreach");

foreach (var item in estados)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("--------------");
System.Console.WriteLine("Imprimindo através do for");

for (int i = 0; i < estados.Count; i++)
{
    System.Console.WriteLine($"Índice {i}: {estados[i]}");
}