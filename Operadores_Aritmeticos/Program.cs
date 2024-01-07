using Operadores_Aritmeticos.Models;

Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Multiplicar(10, 30);
calc.Subtrair(10, 30);
calc.Dividir(10, 30);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);

int numero = 10;

Console.WriteLine($"Incrementando o {numero}");
numero++;
Console.WriteLine($"{numero}");
Console.WriteLine($"Decrementanto o {numero}");
numero--;
Console.WriteLine($"{numero}");

calc.RaizQuadrada(9);