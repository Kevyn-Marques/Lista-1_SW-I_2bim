namespace Ex_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso das classes Fabricante e Produto
            try
            {
                Fabricante fabricante = new Fabricante("Xiomi", "Rua João Pavani, 123", "Ribeirão Pires");
                Produto produto = new Produto("Celular", fabricante, 1450.59m);

                Console.WriteLine($"Nome do Produto: {produto.Nome}");
                Console.WriteLine($"Fabricante: {produto.Fabricante.Nome}");
                Console.WriteLine($"Preço: R${produto.Preco}");
            }
            //Capta os padrões estabelecidos no Produto.cs
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}