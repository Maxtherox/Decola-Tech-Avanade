using System;
using estudoPOO.Helper;
using estudoPOO.Interfaces;
using estudoPOO.Models;

namespace estudoPOO
{
    class Program
    {
         static void Main(string[] args)
         {
             var caminho = "C:\\Users\\gui-r\\OneDrive\\Documentos\\Dio\\Bootcamp-Avanade\\POO_Csharp\\TrabalhandoComArquivos";
             Filehelper helper = new Filehelper();
             helper.ListarDiretorios(caminho);

            //  ICalculadora calc = new Calculadora();
            //  System.Console.WriteLine(calc.Multiplicar(2, 2));
            //  Computador comp = new Computador();
            //  System.Console.WriteLine(comp.ToString());

            //  Corrente c = new Corrente ();
            //  c.Creditar(100);

            //  c.ExibirSaldo();


            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10 ));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10,10,10 ));
            //  Aluno p1 = new Aluno();

            //   p1.Nome ="Guilherme";
            //   p1.Idade = 22;
            //   p1.Nota = 10;


            //   p1.Apresentar();


            //  //valores validos
            //  Retangulo r = new Retangulo();
            //  r.DefinirMedidas(30, 30);

            //  System.Console.WriteLine($"Area:{r.ObterArea()}"); r.ObterArea();


            //      //valores invalidos
            //  Retangulo r2 = new Retangulo();
            //  r.DefinirMedidas(0, 0);

            //  System.Console.WriteLine($"Area:{r2.ObterArea()}"); r2.ObterArea();
             


            //  Pessoa p1 = new Pessoa();

            //  p1.Nome ="Guilherme";
            //  p1.Idade = 22;

            //  p1.Apresentar();

         }
    }
}