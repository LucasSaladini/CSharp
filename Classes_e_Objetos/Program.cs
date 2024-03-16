using System;
using Classes_e_Objetos;

Celular celular1 = new Celular();
celular1.cor = "preto";
celular1.altura = 15.5;
celular1.largura = 8.5;
celular1.modelo = "Motorola";

Console.WriteLine($"Celular 1: É um celular da marca {celular1.modelo}, {celular1.cor}, com {celular1.altura}cm de altura e {celular1.largura}cm de largura");

celular1.fazerChamada(1234567890);