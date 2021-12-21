using System;


namespace Mentoria_3.src.Entities
{
    public class Heroi
    {// encapuslmanento /construtor
        public Heroi(string Nome, string ClasseFantastica ){
                this.Nome = Nome;
                this.Classefantastisca = ClasseFantastica;
                this.Nivel = 1;
                this.PontosDeVida = 50;
                this.PontosDeMagia = 50;
        }

        //propriedades
        public string Nome { get; set; }
        public int PontosDeVida { get; set; }

        public int PontosDeMagia { get; set; }

        public string Classefantastisca { get; set; }

        public int Nivel { get; set; }


        
        public int valorLasthit { get; set; }

       
        public override string ToString(){ //encapsulamento exemplo
            return "Meu nome é " + this.Nome + "\n"
                    + "Meu nivel é: " + this.Nivel + "\n"
                    + "Pontos de vida: " + this.PontosDeVida + "\n"
                    + "Pontos de magia: " + this.PontosDeMagia + "\n"
                    + "Classe: " + this.Classefantastisca;
        }

    public virtual string Atacar (){
        Random dado = new Random ();
        int forcaAtaque = this.Nivel + dado.Next(1, 30);
        this.valorLasthit = forcaAtaque;
        
        return this.Nome + " Atacou e deu: " + + forcaAtaque + " De dano";
    }

        public void ReceberDano(int danoRecebido){
        this.PontosDeVida = this.PontosDeVida - danoRecebido;
    
    }
    }
}


 /* Estrutural version
            //NOME, Pontos de vida, pontos de magia, classe
            string nome = "Arus";
            int healthPoints = 100;
            int magePoints = 5;
            string classeFantastic = "Guerreiro";

            Console.WriteLine("O nome do meu herói é: " + nome );

            string nome2 = "Wedge";
            int healthPoints2 = 60;
            int magePoints2 = 100;
            string classeFantastic2 = "Mago";

            Console.WriteLine("O nome do meu herói é: " + nome2 );

             string nome3 = "Maria";
            int healthPoints3 = 80;
            int magePoints3 = 40;
            string classeFantastic3 = "templaria";
            */