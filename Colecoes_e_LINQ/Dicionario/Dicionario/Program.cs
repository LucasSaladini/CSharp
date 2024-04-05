Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

foreach (var item in estados)
{
    System.Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

System.Console.WriteLine("--------");
System.Console.WriteLine("Acessando um valor do Dictionary");

string valorProcurado = "BA";
System.Console.WriteLine(estados[valorProcurado]);

System.Console.WriteLine("---------");
System.Console.WriteLine("Atuaizando um valor do Dictionary");

estados[valorProcurado] = "BA - Atualizado";

System.Console.WriteLine(estados[valorProcurado]);