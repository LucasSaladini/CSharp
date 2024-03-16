using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Campos_e_Metodos
{
    public class Calculadora
    {
        public int valor1;
        public int valor2;
        public int total;

        public void inserirDados()
        {
            Console.WriteLine("Digite o primeiro valor");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            valor2 = int.Parse(Console.ReadLine());
        }

        public void mostrarResultado()
        {
            Console.WriteLine("O total da operação é: " + total);
        }

        public int Somar()
        {
            return total = valor1 + valor2;
        }

        public int Subtrair()
        {
            return total = valor1 - valor2;
        }

        public int Multiplicar()
        {
            return total = valor1 * valor2;
        }

        public int Divisão()
        {
            return total = valor1 / valor2;
        }
    }
}