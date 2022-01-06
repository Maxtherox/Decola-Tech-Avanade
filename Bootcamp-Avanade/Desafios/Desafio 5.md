# Desafio 5

```
using System;

class desafioCinco
{
    static void Main(string[] args)
    {
        string str;
        while ((str = Console.ReadLine()) != null)
        {
            int x = int.Parse(str);
            if (x > 0)
            {
                Console.WriteLine("vai ter duas!");
            }
            else
            {
                Console.WriteLine("vai ter copa!");
            }
        }
    }
}
```

