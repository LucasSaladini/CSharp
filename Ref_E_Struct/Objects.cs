public ref struct Pessoa
{
  public int Idade { get; set; }
  public string Nome { get; set; }
  public Endereco EnderecoPessoa { get; set; }
}

public ref struct Endereco
{
  public int Numero { get; set; }
  public string Logradouro { get; set; }
  public string CEP { get; set; }
  public string Cidade { get; set; }
}
