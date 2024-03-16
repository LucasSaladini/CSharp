using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_e_Objetos
{
    public class Celular
    {
        public string cor;
        public double altura;
        public double largura;
        public string modelo;

        public void fazerChamada(int numero) {
            Console.WriteLine("fazendo chamada para o número: " + numero);
        }
    }
}