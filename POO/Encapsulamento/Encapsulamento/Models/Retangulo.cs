using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento.Models
{
    public class Retangulo
    {
        private double Comprimento;
        private double Largura;
        private bool valido;

        public void DefinirMedidas(double Comprimento, double Largura)
        {
            if(Comprimento > 0 && Largura > 0)
            {
                this.Comprimento = Comprimento;
                this.Largura = Largura;
                valido = true;
            }
            else
            {
                System.Console.WriteLine("Valores inválidos");
            }
        }

        public double ObterArea()
        {
            if(valido)
            {
                return Comprimento * Largura;
            }
            else
            {
                System.Console.WriteLine("Preencha valores válidos");
                return 0;
            }
        }
    }
}