using System;
using Construtor;

Celular celular = new Celular("vermelho", 15.5, 8.5, "Samsung");
Console.WriteLine($"A cor do celular é {celular.cor}, possuindo uma altura de {celular.altura}cm, uma largura de {celular.largura}cm e é da marca {celular.modelo}");

Celular celular2 = new Celular("azul", 18);
Console.WriteLine($"A cor do celular é {celular2.cor} com uma altura de {celular2.altura}");

Celular celular3 = new Celular("roxo", 12);
celular3.largura = 6;
celular3.modelo = "iPhone";
Console.WriteLine($"A cor do celular é {celular3.cor} com uma altura de {celular3.altura} e {celular3.largura} de largura e é da marca {celular3.modelo}");

Cadeira cadeira = new Cadeira("preta");
Console.WriteLine($"A cor da cadeira é {cadeira.cor}");