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
           
          Console.WriteLine(wedge.Atacar(40));
          Console.WriteLine(Marata.Atacar());

           if( wedge.valorLasthit == Marata.valorLasthit){
               Console.WriteLine (" Empate, ambos deram o dano de: " + wedge.valorLasthit);
           }else if (wedge.valorLasthit > Marata.valorLasthit){
               Marata.ReceberDano(wedge.valorLasthit - Marata.valorLasthit);
               Console.WriteLine(wedge.Nome + " Venceu esse round");
           }else{
               wedge.ReceberDano(Marata.valorLasthit - wedge.valorLasthit);
               Console.WriteLine(Marata.Nome + " Venceu esse round");
    
           }

System.Console.WriteLine("Pontos de vida do inimigo: " + Marata.PontosDeVida);
     
        }


    }

}