using System;
namespace estudoPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            System.Console.WriteLine($"Diretor");
        }
    }
}