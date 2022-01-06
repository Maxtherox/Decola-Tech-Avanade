# Desafio 3 

```
using System;

class desafioTres
{
    static void Main(string[] args)
    {
        double c, S = 0;
        for (float i = 1; i <= 100; i++)
        {
            c = 1 / i;  //coloque a sua lógica nos espaços em branco
            S += c;
        }
        var x = Math.Round(S, 2);
        Console.WriteLine(x);
    }
}
```

