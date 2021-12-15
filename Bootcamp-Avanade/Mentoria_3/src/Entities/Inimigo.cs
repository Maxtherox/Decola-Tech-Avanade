namespace Mentoria_3.src.Entities
{
    public class Inimigo : Heroi
    {
        public Inimigo(string Nome, string ClasseFantastica) : base(Nome, ClasseFantastica){
        }

        public override string Atacar()
        {
        Random dado = new Random ();
        int forcaAtaque = this.Nivel + dado.Next(1, 30);
        this.valorLasthit = forcaAtaque;

        return this.Nome + " Atacou com uma mordida e deu: " + + forcaAtaque + " De dano";
            
        }

    }
}