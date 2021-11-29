using System.Collections.Generic;

namespace colecoes.helper
{
    public class OperacoesLista
    {
        public void ImprimirLista(List<string> lista)
        {
                for (int i = 0; i <lista.Count; i++)
            {
                System.Console.WriteLine($"índice {i}, Valor: {lista[i]}");
            }
        }
    }
}