using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bubble_Sort.Helper
{
    public class OperacoesArray
    {
        public void OrdernarBubbleSort(ref int[] array)
        {
            // Realizar a troca sem perder a informação do valor anterior
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array);
            Console.WriteLine(linha);
        }

        public void Ordernar(ref int[] array)
        {
            Array.Sort(array);
        }

        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }

        public bool Existe(int[] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }
    }
}