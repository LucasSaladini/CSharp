using Interface.Interfaces;
using Interface.Models;

ICalculadora calc = new Calculadora();

System.Console.WriteLine(calc.Somar(10, 20));