using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colecoes_Genericas.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
            System.Console.WriteLine($"Quantidade de elementos na lista: {lista.Count}");

            // System.Console.WriteLine("--------------");
            // System.Console.WriteLine("Imprimindo através do for");

            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"Índice {i}: {lista[i]}");
            }
        }
    }
}