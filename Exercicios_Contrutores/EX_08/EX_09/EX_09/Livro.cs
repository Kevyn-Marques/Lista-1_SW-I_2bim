using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_09
{
    public class Livro
    {
        private string titulo;
        private string autor;

        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {

                    //Estabelece um padrão de:Caso o valor seja nulo ou esteja em branco,dispara a mensagem de erro
                    throw new ArgumentException("O título não pode estar vazio.");
                }
                titulo = value;
            }
        }

        public string Autor
        {
            get { return autor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    //Estabelece um padrão de:Caso o valor seja nulo ou esteja em branco,dispara a mensagem de erro
                    throw new ArgumentException("O autor não pode estar vazio.");
                }
                autor = value;
            }
        }

        // Construtor da classe Livro
        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }
}

