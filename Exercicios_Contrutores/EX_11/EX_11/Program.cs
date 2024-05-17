namespace EX_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso da classe Carro
            Carro carro = new Carro("Fusca Azul Tunado", 1970);
            Console.WriteLine($"Modelo: {carro.Modelo}");
            Console.WriteLine($"Ano: {carro.Ano}");
            Console.WriteLine($"Velocidade inicial: {carro.Velocidade}");

            // Acelerando o carro duas vezes
            carro.Acelerar();
            carro.Acelerar();
            Console.WriteLine($"Velocidade após acelerar duas vezes: {carro.Velocidade}");

            // Freando o carro
            carro.Frear();
            Console.WriteLine($"Velocidade após frear uma vez: {carro.Velocidade}");

            // Tentando frear o carro novamente (para mostrar que a velocidade não fica negativa)
            carro.Frear();
            Console.WriteLine($"Velocidade após tentar frear novamente: {carro.Velocidade}");
        }
    }
}