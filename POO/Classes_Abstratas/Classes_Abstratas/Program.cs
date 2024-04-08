using Classes_Abstratas.Models;

Corrente c = new Corrente();

c.Creditar(100);
c.ExibirSaldo();

Computador comp = new Computador();

System.Console.WriteLine(comp.ToString());