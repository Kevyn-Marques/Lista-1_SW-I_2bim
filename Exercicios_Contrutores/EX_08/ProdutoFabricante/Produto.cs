using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Fabricante
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }

    // Construtor da classe Fabricante
    public Fabricante(string nome, string endereco, string cidade)
    {
        Nome = nome;
        Endereco = endereco;
        Cidade = cidade;
    }
}

 public class Produto
{
    public string Nome { get; set; }
    public Fabricante Fabricante { get; set; }
   
    private decimal preco;

    public decimal Preco
    {
        get { 
            return preco; 
        }
        set
        {
            if (value >= 0)
            {
                preco = value;
            }
            else
            {
                //Estabelece um padrão de:Caso o valor negativo,será lançado(throw) a mensagem de erro
                throw new ArgumentException("O preço deve ser positivo.");
            }
        }
    }

    // Construtor da classe Produto
    public Produto(string nome, Fabricante fabricante, decimal preco)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            //Estabelece um padrão de:Caso o valor seja nulo ou esteja em branco,será lançado(throw) a mensagem de erro
            throw new ArgumentException("O nome não pode estar vazio.");
        }

        Nome = nome;
        Fabricante = fabricante;
        Preco = preco;
    }
}
