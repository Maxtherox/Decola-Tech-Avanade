namespace estudoPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é: {Nome} e trabalho como professor, meu salario é: {Salario} Reais.");
        }
    }
}