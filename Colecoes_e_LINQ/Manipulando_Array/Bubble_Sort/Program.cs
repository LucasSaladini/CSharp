using Bubble_Sort.Helper;

OperacoesArray op = new OperacoesArray();
int[] array = new int[5] { 6, 3, 8, 1, 9 };

Console.WriteLine("Array Original");
op.ImprimirArray(array);

op.OrdernarBubbleSort(ref array);

Console.WriteLine("Array Ordenado");
op.ImprimirArray(array);