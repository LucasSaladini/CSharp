using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_Abstratas.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }
        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome} e sou um aluno nota  {Nota}");
        }
    }
}