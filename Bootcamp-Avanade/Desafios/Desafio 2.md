# Desafio 2

using System;

class desafioDois
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                int b = i * i;          
                Console.WriteLine(i + "^2 = " + b);
            }
        }
    }
}