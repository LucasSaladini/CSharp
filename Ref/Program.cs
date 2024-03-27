using static System.Console;

class Ref
{
  static void Demo1()
  {
    int a  = 5;
    
    Adicionar20(ref a);
    
    WriteLine($"O valor de a é {a}");
  }
  static void Adicionar20(ref int a)
  {
    a += 20;
  }
  static void AlterarNome(string[] nomes, string nome, string nomeNovo)
  {
    for(int i = 0; i < nomes.Length; i++)
    {
      if(nomes[i] == nome)
      {
        nomes[i] = nomeNovo;
      }
    }
  }
  static void Main()
  {
    var nomes = new string[] {"José", "Maria", "Ricardo", "Alice", "Pedro"};
    WriteLine("Digite o nome que deseja que seja substituído");
    var nome = ReadLine();
    WriteLine("Digite o nome novo:");
    var nomeNovo = ReadLine();

    AlterarNome(nomes, nome, nomeNovo);

    WriteLine($@"A lista de nomes Alterada é:
      {string.Join(", \n", nomes)}
    ");
  }
}
