using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "Lucas";
p1.Idade = 30;
p1.EnderecoPessoa = new Endereco ()
{
  Logradouro = "Rua Teste",
  Cidade = "São Paulo",
  CEP = "00000000",
  Numero = 300
};

WriteLine("Fim");
