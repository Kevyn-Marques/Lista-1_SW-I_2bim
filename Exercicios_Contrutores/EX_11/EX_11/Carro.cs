using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_11
{
    public class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        private int velocidade;

        public int Velocidade
        {
            get { return velocidade; }
            private set
            {
                // A velocidade não pode ser negativa
                velocidade = Math.Max(value, 0);
            }
        }

        // Construtor da classe Carro
        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
            Velocidade = 0; // Inicialmente, o carro está parado
        }

        // Método para acelerar o carro
        public void Acelerar()
        {
            Velocidade += 10;
        }

        // Método para frear o carro
        public void Frear()
        {
            Velocidade -= 10;
        }
    }
}

