namespace EX_09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso da classe Livro
            try
            {
                Livro livro = new Livro("A Moreninha", "Joaquim Manoel de Macedo");

                Console.WriteLine($"Título: {livro.Titulo}");
                Console.WriteLine($"Autor: {livro.Autor}");
            }
            //Capta os padrões estabelecidos no Livro.cs
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}