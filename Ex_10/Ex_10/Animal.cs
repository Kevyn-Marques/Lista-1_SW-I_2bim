using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10
{
    public class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }

        // Construtor da classe Animal
        public Animal(string nome, string especie, int idade)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
        }

        // Método para emitir som do animal
        public virtual void EmitirSom()
        {
            if(Especie == "Cachorro")
            {
                Console.WriteLine("Esse animal late:AUAU.");
            }
            else if(Especie== "Gato")
            {
                Console.WriteLine("Esse animal mia:Meown");
            }
        }
    }
}
