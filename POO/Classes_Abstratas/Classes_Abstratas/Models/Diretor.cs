using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_Abstratas.Models
{
    public sealed class Diretor : Professor
    {
        public sealed override void Apresentar()
        {
            System.Console.WriteLine($"Diretor");
        }
    }
}