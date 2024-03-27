using static System.Console;
using Value_Types_e_Reference_Types.Models;

public class Program
{
    static int Adicionar20(int a)
    {
        return a + 20;
    }

	static void Demo5()
	 {
  		int[] pares = new int[]{0, 2, 4, 6, 8}; 

			MudarParaImpar(pares);

			WriteLine($"Os ímpares {string.Join(",", pares)}");
	 }
   static void Demo4()
  {
    string nome = "Ricardo";

    TrocarNome(nome, "José");

    WriteLine($"O novo nome é {nome}");

  }
	static void Demo4()
	{
		string nome = "Lucas";

		TrocarNome(nome, "José");

		WriteLine($"O novo nome é {nome}");
	}
  static void Demo3()
  {
    StructPessoa p1 = new StructPessoa
    {
      Documento = "1234",
      Idade = 30,
      Nome = "Ricardo"
    };

    var p2 = p1;

    p1 = TrocarNome(p1, "João");

    WriteLine($@"
      Nome do p1 {p1.Nome}
      Nome do p2 {p2.Nome}
    ");

  }
  static void Demo2()
  {
    Pessoa p1 = new Pessoa();
    p1.Nome = "Ricardo";
    p1.Idade = 30;
    p1.Documento = "1234";

    Pessoa p2 = p1.Clone();

    TrocarNome(p1,"José");

    

    WriteLine($@"
    O nome de p1 é :{p1.Nome}
    O nome de p2 é :{p2.Nome}
    ");

  }
  static void Demo1()
  {
    int a = 2;
    a = Adicionar20(a);

    WriteLine($"O Valor da variável a é {a}");

  }
  static int Adicionar20(int x)
  {
    return x + 20;
  }

  static void TrocarNome(Pessoa p1, string nomeNovo)
  {
    p1.Nome = nomeNovo;
  }

  static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo)
  {
    p1.Nome = nomeNovo;
    return p1;
  }

  static void TrocarNome(string nome, string nomeNovo)
  {
    nome = nomeNovo;

  }

	static void MudarParaImpar(int[] pares)
	{
		for(int i = 0; i < pares.length; i++)
		{
			pares[i] = pares[i] + 1;
		}
	}
	
    public static void Main()
  {
  }
}
