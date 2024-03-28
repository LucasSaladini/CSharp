using System;
using Delegates.Models;

namespace Delegates{
    class Program
    {
        //Operacao op = Calculadora.Somar;
        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {
            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair;
            
            op.Invoke(10, 10);
            op(10, 10);
        }
    }
}