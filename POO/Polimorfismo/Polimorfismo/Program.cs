using Polimorfismo.Models;

Aluno a1 = new Aluno();

a1.Nome = "Bob";
a1.Nota = 10;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Leo";
p1.Salario = 1000;
p1.Apresentar();

Calculadora calc = new Calculadora();
System.Console.WriteLine($"Resultado da primeira soma: {calc.Somar(10, 10)}");
System.Console.WriteLine($"Resultado da segunda soma: {calc.Somar(15, 20, 50)}");