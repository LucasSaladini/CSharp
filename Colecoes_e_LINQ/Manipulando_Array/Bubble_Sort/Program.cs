using Bubble_Sort.Helper;

OperacoesArray op = new OperacoesArray();
int[] array = new int[5] { 6, 3, 8, 1, 9 };
int[] arrayCopia = new int[10];

// Console.WriteLine("Array Original");
// op.ImprimirArray(array);

// op.OrdernarBubbleSort(ref array);

// Console.WriteLine("Ordenando através do Array.Sort()");
// op.Ordernar(ref array);

// Console.WriteLine("Array Ordenado");
// op.ImprimirArray(array);

Console.WriteLine("Array antes da cópia");
op.ImprimirArray(arrayCopia);

op.Copiar(ref array, ref arrayCopia);

Console.WriteLine("Array após a cópia");
op.ImprimirArray(arrayCopia);