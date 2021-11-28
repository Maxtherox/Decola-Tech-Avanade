namespace estudoPOO.Models
{
    public class Retangulo
    {
        // propriedades // 
        private double comprimento;
        private double largura;
        private bool valido;
        // método capaz de alterar essas duas propriedades//
        public void DefinirMedidas(double comprimento, double largura)
        {
            if (comprimento > 0 && largura > 0)
            {
            //colocar atributo que estou recebendo como parametro para o atributo privado da classe retangulo
            this.comprimento = comprimento;
            this.largura = largura;
            valido = true;
            }        
            else
            {
                System.Console.WriteLine("Valores incorretos");
            }

        }

        public double ObterArea()
        {
            if(valido)
            {
                return comprimento * largura;
            }
            else
            {
                System.Console.WriteLine("Preencha valores validos");
                return 0;
            }

        }
    }
}