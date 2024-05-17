using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_12
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Altura { get; set; }

        // Construtor da classe Pessoa
        public Pessoa(string nome, int idade, float altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        // Método para formatar os dados da pessoa em uma string
        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Altura: {Altura}";
        }
    }

    class Agenda
    {
        private List<Pessoa> pessoas = new List<Pessoa>();

        // Método para armazenar uma pessoa na agenda
        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa pessoa = new Pessoa(nome, idade, altura);
            pessoas.Add(pessoa);
        }

        // Método para remover uma pessoa da agenda pelo nome
        public void RemovePessoa(string nome)
        {
            Pessoa pessoa = BuscaPessoa(nome);
            if (pessoa != null)
            {
                pessoas.Remove(pessoa);
                Console.WriteLine($"Pessoa '{nome}' removida com sucesso.");
            }
            else
            {
                Console.WriteLine($"Pessoa '{nome}' não encontrada na agenda.");
            }
        }

        // Método para buscar uma pessoa na agenda pelo nome
        public Pessoa BuscaPessoa(string nome)
        {
            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == nome)
                {
                    return pessoa;
                }
            }
            return null;
        }

        // Método para imprimir os dados de todas as pessoas da agenda
        public void ImprimeAgenda()
        {
            if (pessoas.Count == 0)
            {
                Console.WriteLine("A agenda está vazia.");
            }
            else
            {
                Console.WriteLine("Agenda:");
                foreach (Pessoa pessoa in pessoas)
                {
                    Console.WriteLine(pessoa);
                }
            }
        }
    }
}