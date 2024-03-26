using static System.Console;
using Value_Types_e_Reference_Types.Models;

public class Program
{
    static int Adicionar20(int a)
    {
        return a + 20;
    }

    static void Demo1()
    {
        int a = 2;
        a = Adicionar20(a);
        WriteLine($"O valor da variável a é {a}");
    }

    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Lucas";
        p1.Idade = 30;
        p1.Documento = "1234";

        Pessoa p2 = p1;

        TrocarNome(p1, "José");

        WriteLine($@"
        O nome de p1 é: {p1.Nome}
        O nome de p2 é: {p2.Nome}
        ");
    }
}