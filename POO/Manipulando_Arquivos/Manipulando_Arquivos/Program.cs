using Manipulando_Arquivos.Helper;

var path = "C:\\Users\\lucas.saladini\\Desktop\\Nova pasta";
var pathCombine = Path.Combine(path, "Pasta Teste", "Sub Pasta Teste");
var pathArquivo = Path.Combine(path, "arquivo-teste.txt");
var pathArquivoStream = Path.Combine(path, "arquivo-stream.txt");
var pathNew = Path.Combine(path, "Pasta Teste", "arquivo-movido.txt");
var pathArquivoCopia = Path.Combine(path, "arquivo-test-bkp.txt");

var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
var listaAdicao = new List<string> { "Linha 4", "Linha 5", "Linha 6"};


FileHelper helper = new FileHelper();

System.Console.WriteLine("Diretórios");
helper.ListarDiretorios(path);
System.Console.WriteLine("----------");

System.Console.WriteLine("Arquivos");
helper.ListarArquivos(path);
System.Console.WriteLine("----------");

System.Console.WriteLine("Criar Diretório");
helper.CriarDiretorio(Path.Combine(pathCombine));
System.Console.WriteLine("----------");

System.Console.WriteLine("Apagando Diretório");
helper.ApagarDiretorio(pathCombine, true);
System.Console.WriteLine("----------");

System.Console.WriteLine("Criando arquivo de texto");
helper.CriarArquivoTexto(pathArquivo, "Olá, teste de escrita de arquivo");
System.Console.WriteLine("----------");

System.Console.WriteLine("Criando arquivo de texto via stream");
helper.CriarArquivoTextoStream(pathArquivoStream, listaString);
System.Console.WriteLine("----------");

System.Console.WriteLine("Adicionado ao arquivo de texto via stream");
helper.AdicionarTextoStream(pathArquivoStream, listaAdicao);
System.Console.WriteLine("----------");

System.Console.WriteLine("Lendo arquivo de texto");
helper.LerArquivoStream(pathArquivoStream);
System.Console.WriteLine("----------");

System.Console.WriteLine("Movendo um arquivo");
helper.MoverArquivo(pathArquivoStream, pathNew, true);
System.Console.WriteLine("----------");

System.Console.WriteLine("Copiando um arquivo");
helper.CopiarArquivo(pathNew, pathArquivoCopia, true);
System.Console.WriteLine("----------");

System.Console.WriteLine("Apagando um arquivo");
helper.ApagarArquivo(pathArquivoCopia);
System.Console.WriteLine("----------");