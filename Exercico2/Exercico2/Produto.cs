using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico2
{
     class Produto
    {
        private int codigo { get; set; }

        private string nome { get; set; }

        private int estoque;

        private Double valor { get; set; }
        

        public Produto(int Cod,string Nom,int Est,Double Val) {

            codigo= Cod;
            nome= Nom;
            estoque= Est;
            valor= Val;
        }
        public void entrada(int quantia)
        {
            estoque = estoque + quantia;
            Console.WriteLine("Entrada de " + quantia);
        }
        public void venda (int qntd)
        {
           estoque = estoque- qntd;
           Console.WriteLine("Venda de " + qntd );
        }
        
        public void imprimir()
        {
            Console.WriteLine("Dados do Produto");
            Console.WriteLine("Cod: " + codigo);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Estoque: " + estoque);
            Console.WriteLine("Valor: " + valor);
        }
    }
}
