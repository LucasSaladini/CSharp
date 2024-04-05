using System.Collections.Generic;
using Colecoes_Genericas.Helper;

OperacoesLista opLista = new OperacoesLista();
List<string> estados = new List<string>();
string[] estadosArray = new string[2] { "SC", "MT" };

estados.Add("SP");
estados.Add("MG");
estados.Add("BA");

// System.Console.WriteLine("--------------");
// System.Console.WriteLine("Imprimindo através do foreach");

// foreach (var item in estados)
// {
//     System.Console.WriteLine(item);
// }

opLista.ImprimirListaString(estados);

// System.Console.WriteLine("Removendo o elemento");
// estados.Remove("MG");

estados.Insert(1, "RJ");

estados.AddRange(estadosArray);

opLista.ImprimirListaString(estados);