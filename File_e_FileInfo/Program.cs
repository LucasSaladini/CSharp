using static System.Console;
using System.IO;

WriteLine("Digite o nome do arquivo:");
var nome = ReadLine();
nome = LimparNome(nome);
    
var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);

WriteLine("Digite enter para finalizar");
ReadLine();

static string LimparNome(string nome)
{
    foreach(var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }
    return nome;
}

static void CriarArquivo(string path)
{
    try
    {
        var sw = File.CreateText(path);
        sw.WriteLine("Está é a linha 1 do arquivo");
        sw.WriteLine("Está é a linha 2 do arquivo");
        sw.WriteLine("Está é a linha 3 do arquivo");
        sw.Flush();
    } 
    catch
    {
        WriteLine("O nome do arquivo está inválido:");
    }
}

// var path2 = Path.Combine(Environment.CurrentDirectory, "teste2.txt");

// static void CriarArquivo2()
// {
//     using var sw2 = File.CreateText(path2);
//     sw2.WriteLine("Está é a linha 4 do arquivo");
//     sw2.WriteLine("Está é a linha 5 do arquivo");
//     sw2.WriteLine("Está é a linha 6 do arquivo");
// }