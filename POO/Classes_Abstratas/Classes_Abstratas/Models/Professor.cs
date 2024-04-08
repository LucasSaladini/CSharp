using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_Abstratas.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }
        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}, sou professor e meu salário é {Salario}");
        }
    }
}