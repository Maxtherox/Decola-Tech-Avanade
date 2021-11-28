using System;
using ExemploConstrutores.Models;


namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(String[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();

            // Operacao op = Calculadora.Somar;
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;
            // op.Invoke(10, 10);

            //op(10, 10);

            // Data data = new Data();
            // data.SetMes(5);

            // data.ApresentarMes();



            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log.PropriedadeLog);

            // Pessoa p1 = new Pessoa("Guilherme","De Jesus");
            // p1.Apresentar();
        }
    }
}