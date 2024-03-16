using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace CSV_Helper.Model
{
    public class Livro
    {
        // [Index(0)]
        // [Name("titulo")]
        public string Titulo { get; set; }
        // [Index(2)]
        // [Name("autor")]
        public string Autor { get; set; }
        // [Index(1)]
        // [Name("preço")]
        // [CultureInfo("pt-BR")]
        public decimal Preco { get; set; }
        // [Index(3)]
        // [Name("lançamento")]
        // [Format("dd/mm/yyyy")]
        public DateOnly Lancamento { get; set; }
    }
}