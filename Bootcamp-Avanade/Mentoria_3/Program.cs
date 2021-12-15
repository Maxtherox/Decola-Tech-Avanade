using System;
using Mentoria_3.src.Entities;

namespace POO_mentoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroi arus = new Heroi("Arus", "Guerreiro");
            Mago wedge = new Mago("Wedge", "Mago");
            Inimigo Marata = new Inimigo("Marata", "Humano");
           
          Console.WriteLine(wedge.Atacar(10));
          Console.WriteLine(Marata.Atacar());

           if( wedge.valorLasthit == Marata.valorLasthit){
               Console.WriteLine (" Empate, ambos deram o dano de: " + arus.valorLasthit);
           }else if (arus.valorLasthit > Marata.valorLasthit){
               Marata.ReceberDano(arus.valorLasthit - Marata.valorLasthit);
               Console.WriteLine(arus.Nome + " Venceu esse round");
           }else{
               arus.ReceberDano(Marata.valorLasthit - arus.valorLasthit);
               Console.WriteLine(Marata.Nome + " Venceu esse round");
           }


     
        }


    }

}