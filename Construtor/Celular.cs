using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtor
{
    public class Celular
    {
        public Celular() 
        {

        }

        public Celular(string _cor, double _altura, double _largura, string _modelo)
        {
            this.cor = _cor;
            this.altura = _altura;
            this.largura = _largura;
            this.modelo = _modelo;
        }

        public Celular(string _cor, double _altura)
        {
            this.cor = _cor;
            this.altura = _altura;
        }

        public string cor;
        public double altura;
        public double largura;
        public string modelo;
    }
}