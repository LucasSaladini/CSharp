using ExemploConstrutores.Models;

Pessoa p1 = new Pessoa("Lucas", "Saladini");
p1.Apresentar();

Log log = Log.GetInstance();

log.PropriedadeLog = "Teste instância";

Log log2 = Log.GetInstance();
System.Console.WriteLine(log2.PropriedadeLog); 

Aluno a1 = new Aluno("Lucas", "Saladini", "Teste");
a1.Apresentar();