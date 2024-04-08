using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }
        // Polimorfismo em tempo de execução
        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome} e eu sou um aluno nota {Nota}");
        }
    }
}