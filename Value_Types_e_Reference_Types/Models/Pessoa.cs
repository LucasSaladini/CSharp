using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Value_Types_e_Reference_Types.Models
{
    public class Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
    }

    public Pessoa Clone()
    {
        return new Pessoa()
        {
            Documento = this.Documento,
            Idade = this.Idade,
            Nome = this.Nome
        }
    }
}
