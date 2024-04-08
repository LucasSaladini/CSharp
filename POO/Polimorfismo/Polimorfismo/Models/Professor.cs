using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }
        // Polimorfismo em tempo de execução
        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}, sou um professor e meu salário é {Salario}");
        }
    }
}