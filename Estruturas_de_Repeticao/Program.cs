﻿// int numero = 5;

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }

// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");

//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    // Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            // Environment.Exit(0);
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

Console.WriteLine("O programa se encerrou");