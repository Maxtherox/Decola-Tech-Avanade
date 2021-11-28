using System;
using Primeiro;
using Csharp;
using Interface;
using Enum;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Guilherme;
            Pessoas pessoa3 = Pessoas.Julia;
            Pessoas pessoa4 = (Pessoas)4;


            Pessoa person = new Pessoa();
            person.Nome = "Guilherme";
            person.Idade = 22;
            person.Estado = "São Paulo";


            var person2 = new Pessoa();

            person2.Nome = "Isaac";
            person2.Idade = 4;
            person2.Estado = "São paulo";

            Animal animal = new Animal();

            animal.nome = "Rodolfo";
            animal.nomeDono = "Ronaldo";
            animal.especie = "Bulldog";

            var classe = new Classe();
            var classe2 = new Segundo.Classe();

            Console.WriteLine(pessoa3);
        }
    }
}
