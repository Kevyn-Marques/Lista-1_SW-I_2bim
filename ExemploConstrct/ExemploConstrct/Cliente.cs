using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrct
{
    public class Cliente
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int Senha { get; set; }


        public Cliente(int senhaConstrutor , string nomeConstrutor)
        {
            Senha = senhaConstrutor;
            Nome = nomeConstrutor;
        }
        public void MostraDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Senha: " + Senha);
            Console.WriteLine("E-mail: " + Email);
        }
    }
}
