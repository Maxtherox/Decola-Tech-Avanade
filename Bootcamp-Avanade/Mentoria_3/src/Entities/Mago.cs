using System;

namespace Mentoria_3.src.Entities
{
    public class Mago : Heroi//herança
    { 
         public Mago(string Nome, string ClasseFantastica) : base(Nome, ClasseFantastica){

         }
        

        public override string Atacar(){
             Random dado = new Random ();
        int forcaAtaque = this.PontosDeMagia + dado.Next(1, 30);
                this.valorLasthit = forcaAtaque;

        
        return this.Nome + " Atacou e com seu cajado: " + + forcaAtaque + " De dano";
            
        }

      public string Atacar(int bonus){
            Random dado = new Random();
            int ForcaAtaque = this.Nivel + dado.Next(1,10) + bonus;

            this.valorLasthit = ForcaAtaque;

            return this.Nome + " Atacar com bonus com seu cajado e da " + ForcaAtaque + "de dano";
        }
        
 
    }
}