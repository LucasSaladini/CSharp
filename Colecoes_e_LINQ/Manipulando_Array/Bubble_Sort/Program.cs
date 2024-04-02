using Bubble_Sort.Helper;

OperacoesArray op = new OperacoesArray();
int[] array = new int[5] { 6, 3, 8, 1, 9 };
int[] arrayCopia = new int[10];

int valorProcurado = 10;

string[] arrayString = op.ConverterParaArrayString(array);

// System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

// op.RedimensionarArray(ref array, array.Length * 2);

// System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");

// int valorAchado = op.ObterValor(array, valorProcurado);
// int indiceValor = op.ObterIndice(array, valorProcurado);

// if(valorAchado > 0)
// {
//     Console.WriteLine("Encontrei o valor");
//     if(indiceValor > -1)
//         Console.WriteLine("O valor {0} está no índice {1}", valorProcurado, indiceValor);
// }
// else
// {
//     Console.WriteLine("Não encontrei o valor");
// }

// bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

// if (todosMaiorQue)
// {
//     Console.WriteLine("Todos os valores são maior que {0}", valorProcurado);
// }
// else
// {
//     Console.WriteLine("Existe valores que não são maiores do que {0}", valorProcurado);
// }

// bool existe = op.Existe(array, valorProcurado);

// if (existe)
// {
//     Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
// }
// else 
// {
//     Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
// }

// Console.WriteLine("Array Original");
// op.ImprimirArray(array);

// op.OrdernarBubbleSort(ref array);

// Console.WriteLine("Ordenando através do Array.Sort()");
// op.Ordernar(ref array);

// Console.WriteLine("Array Ordenado");
// op.ImprimirArray(array);

// Console.WriteLine("Array antes da cópia");
// op.ImprimirArray(arrayCopia);

// op.Copiar(ref array, ref arrayCopia);

// Console.WriteLine("Array após a cópia");
// op.ImprimirArray(arrayCopia);