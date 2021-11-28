using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IAnimal
    {
        void Nome(string nome);
        void Dono(string nomeDono);
        void Especie(string especie);
    }

    class Animal : IAnimal
    {
        public string nome { get; set; }
        public string nomeDono { get; set; }
        public string especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.nome = nome;
        }

        void IAnimal.Dono(string nomeDono)
        {
            this.nomeDono = nomeDono;
        }

        void IAnimal.Especie(string especie)
        {
            this.especie = especie;
        }

    }
}
