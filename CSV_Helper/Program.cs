using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;
using CSV_Helper.Model;
using CSV_Helper.Mapping;

// LerCSVComDynamic();
// LerCsvComClasse();
// LerCsvComOutroDelimitador();
EscreverCsv();

Console.WriteLine("Digite [enter] para finalizar");
Console.ReadLine();

static void EscreverCsv()
{
    var path = Path.Combine(
        Environment.CurrentDirectory,
        "Saída"
    );

    var di = new DirectoryInfo(path);

    if(!di.Exists)
        di.Create();

    path = Path.Combine(path, "usuarios.csv");

    var pessoas = new List<Pessoa>()
    {
        new Pessoa()
        {
            Nome = "José da Silva",
            Email = "js@gmail.com",
            Telefone = 123456
        },
        new Pessoa()
        {
            Nome = "Pedro Paiva",
            Email = "pp@gmail.com",
            Telefone = 456789
        },
        new Pessoa()
        {
            Nome = "Maria Antonia",
            Email = "ma@gmail.com",
            Telefone = 123456
        },
        new Pessoa()
        {
            Nome = "Carla Moraes",
            Email = "cms@gmail.com",
            Telefone = 9987411
        },
    };

    using var sr = new StreamWriter(path);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = "|"
    };
    using var csvWriter = new CsvWriter(sr, csvConfig);
    csvWriter.WriteRecords(pessoas);
}

static void LerCsvComOutroDelimitador() {
var path = Path.Combine(
        Environment.CurrentDirectory,
        "Entrada",
        "livros-preco-com-virgula.csv"
    );

    var fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe!");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };
    using var csvReader = new CsvReader(sr, csvConfig);
    csvReader.Context.RegisterClassMap<LivroMap>();

    var registros = csvReader.GetRecords<Livro>().ToList();

    foreach(var registro in registros)
    {
        Console.WriteLine($"título: {registro.Titulo}");
        Console.WriteLine($"preço: {registro.Preco}");
        Console.WriteLine($"autor: {registro.Autor}");
        Console.WriteLine($"lançamento: {registro.Lancamento}");
        Console.WriteLine("--------------");
    }
}

static void LerCsvComClasse()
{
    var path = Path.Combine(
        Environment.CurrentDirectory,
        "Entrada",
        "novos-usuarios.csv"
    );

    var fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe!");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Usuario>();

    foreach(var registro in registros)
    {
        Console.WriteLine($"nome: {registro.Nome}");
        Console.WriteLine($"email: {registro.Email}");
        Console.WriteLine($"telefone: {registro.Telefone}");
        Console.WriteLine("--------------");
    }

}

static void LerCSVComDynamic()
{
    var path = Path.Combine(
        Environment.CurrentDirectory,
        "Entrada",
        "Produtos.csv"
    );

    var fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe!");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<dynamic>();

    foreach(var registro in registros)
    {
        Console.WriteLine($"nome: {registro.Produto}");
        Console.WriteLine($"marca: {registro.Marca}");
        Console.WriteLine($"preço: {registro.Preco}");
        Console.WriteLine("--------------");
    }
}