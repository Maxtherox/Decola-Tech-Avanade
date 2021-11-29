using System;
using System.Collections.Generic;
using colecoes.helper;

namespace Colecoes
{
    class Program
    {
        static void Main(String[] args)
        {   

            int[] arrayNumeros = new int[10] {8, 4, 5, 19, 2, 100, 1, 19, 2, 8};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();


            System.Console.WriteLine($"Minimo: {minimo}");
            System.Console.WriteLine($"Medio: {medio}");
            System.Console.WriteLine($"Maximo: {maximo}");
            System.Console.WriteLine($"Soma: {soma} " );
            System.Console.WriteLine($"Array original: {string.Join(",", arrayNumeros)}");
            System.Console.WriteLine($"Array Distinto: {string.Join(",", arrayUnico)}");

            // //LINQ query sintax
            // var numerosParesQuery = 
            //         from num in arrayNumeros
            //         where num % 2 == 0 
            //         orderby num
            //         select num;


            // //LINQ Method syntax
            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            // System.Console.WriteLine("Numeros pares query: " + string.Join(",", numerosParesQuery));
            // System.Console.WriteLine("Numeros pares método: " + string.Join(",", numerosParesMetodo));



            // Dictionary<string, string> estados = new Dictionary<string, string>();

            // estados.Add("São Paulo", "SP");
            // estados.Add("Rio de janeiro", "RJ");
            // estados.Add("Bahia", "BA");

            // // foreach (KeyValuePair<string, string> item in estados)
            // // {
            // //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // // }


            // // remove
            // // estados.Remove(valorProcurado);
            // string valorProcurado = "Bahia";
            // System.Console.WriteLine("Valor original: ");
            // System.Console.WriteLine(estados[valorProcurado]);


            // estados[valorProcurado] = "Ba - teste atualização";

            // System.Console.WriteLine("Valor atualizado: ");
            // System.Console.WriteLine(estados[valorProcurado]);
            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push(".net");
            // pilhaLivros.Push("c#");
            // pilhaLivros.Push("JS");

            // while (pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Proximo livro para leitura: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            // }

            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Leonardo");
            // fila.Enqueue("Guilherme");
            // fila.Enqueue("Ronaldo");
            // fila.Enqueue("Lara");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }
            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string>();
            // string[] estadosArray = new string[2] {"SC", "SSP"};

            // estados.Add("SP");
            // estados.Add("BA");
            // estados.Add("MG");
            // estados.Add("RJ");

            // System.Console.WriteLine($"Quantidade de elementos na lina: {estados.Count}");

            // opLista.ImprimirLista(estados);


            // // System.Console.WriteLine("Removendo o elemento");
            // // estados.Remove("SP");
            // //adicionando 1 em espefico
            // // estados.Insert(1, "r3");
            // System.Console.WriteLine("Adicionado estados novos");
            // estados.AddRange(estadosArray);
            // opLista.ImprimirLista(estados);

            // for (int i = 0; i <estados.Count; i++)
            // {
            //     System.Console.WriteLine($"índice {i}, Valor: {estados[i]}");
            // }


            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine(item);
            // }

            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5]{ 6, 3, 8, 1, 9};
            // int[] arrayCopia = new int[10];
            // string[] arrayString = op.ConverterParaArrayString(array);
            // // int valorProcurado= 91;

            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

            // op.RedimensionarArray(ref array, array.Length *2);

            // System.Console.WriteLine($"Capacidade atual do array após redimensionamento: {array.Length}");


            // System.Console.WriteLine(array);
            // int indice = op.ObterIndice(array, valorProcurado);
            // if (indice > -1)

            // {
            //     System.Console.WriteLine("Indice {0} é: {1}", valorProcurado, indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor informado não existe");
            // }


            // int ValorAchado = op.ObterValor(array, valorProcurado);
            
            // if (ValorAchado > 0)
            // {
            //     System.Console.WriteLine("Valor encontrado");
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não encontrado");
            // }










            // int valorProcurado= 14;
            // bool existe = op.Existe(array, 1);

            // if (existe)
            // {
            //     System.Console.WriteLine("Valor encontrado {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não encontrado", valorProcurado);
            // }



            // System.Console.WriteLine("Array Original");
            // op.ImprimirArray(array);
        

            // op.Ordenar(ref array);
            // //op.OrdenarBubbleSort(array);

            // System.Console.WriteLine("Array ordenado");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Antes da cópia");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array após a cópia");
            // op.ImprimirArray(arrayCopia);



        }
        //     //array multidimensional
        // int[,] matriz = new int[4,2]
        // {
        //     {2, 2},
        //     {2, 3},
        //     {2, 1},
        //     {10,20}
        // };
        //     //for pra linha
        //   for (int i = 0; i < matriz.GetLength(0); i++)
        //   {    //for pra coluna
        //       for (int j = 0; j < matriz.GetLength(1); j++)
        //       {
        //           System.Console.WriteLine(matriz[i, j]);
        //       }
          

        //matriz[0,0] = 5;



        // //array exemplo
        //      int[] arrayInteiros = new int[3];

        //     arrayInteiros[0] = 10;
        //     arrayInteiros[1] = 20;
        //     arrayInteiros[2] = 30;
        //      //For
        //      System.Console.WriteLine("processando array pelo For");

        //     for (int i = 0; i < arrayInteiros.Length; i++)
        //     {
        //         System.Console.WriteLine(arrayInteiros[i]);
        //     }
        //     // foreach
        //     System.Console.WriteLine("processando array pelo for each");
        //     foreach(int item in arrayInteiros)
        //     {
        //         System.Console.WriteLine(item);
        //     }

       // }
    }  
}