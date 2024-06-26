using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.Models
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora();
        public static event DelegateCalculadora EventoCalculadora;
        public static void Somar(int x, int y)
        {
            if(EventoCalculadora != null)
            {
            System.Console.WriteLine($"Soma: {x + y}");
            EventoCalculadora();
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito");
            }
        }

        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtração: {x - y}");
        }
    }
}