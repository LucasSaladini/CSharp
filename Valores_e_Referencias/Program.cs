using static System.Console;

Numero a = New Numero(2);
Numero b = New Numero(2);

if(a.N == b.N)
{
  WriteLine($"a e b são iguais");
}
else
{
  WriteLine($"a e b são diferentes");
}

class Numero
{
  public int N { get; set;}
  public Numero(int n)
  {
    N = n;
  }
}
