using Encapsulamento.Models;

Retangulo retangulo = new Retangulo();

retangulo.DefinirMedidas(10, -1);

System.Console.WriteLine($"Área: {retangulo.ObterArea()}");