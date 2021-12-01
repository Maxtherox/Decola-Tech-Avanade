**Desafio Xenlongão**



    using System;
    
    class Xenlongao
    {
    static void Main(string[] args)
    {
    
        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
        	//numero de esferas
            int nBalls = int.Parse(Console.ReadLine());
            //numero de divisões
            int nDiv = 0;
            //ignorar as esferar
            int igBalls = 1;
            for (int j = 2; j <= nBalls; j++)
            {
                nDiv = 0;
                for (int k = 1; k <= j; k++)
                {
                    if (j % k == 0)
                    {
                        nDiv++;
                    }
                }
                if (nDiv % 2 != 0)
                {
                    igBalls++;
                }
            }
            Console.WriteLine(nBalls - igBalls);
        }
    }
    }
