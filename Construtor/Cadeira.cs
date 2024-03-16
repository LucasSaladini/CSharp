using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtor
{
    public class Cadeira
    {
        public Cadeira()
        {

        }

        public Cadeira(string _cor, double _altura, double _largura, double _peso)
        {
            this.cor = _cor;
            this.altura = _altura;
            this.largura = _largura;
            this.peso = _peso;
        }

        public Cadeira(string _cor)
        {
            this.cor = _cor;
        }

        public string cor;
        public double altura;
        public double largura;
        public double peso;
    }
}