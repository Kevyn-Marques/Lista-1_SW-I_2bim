namespace Ex_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso da classe Animal
            Animal animal = new Animal("Rex", "Gato", 5);
            Console.WriteLine($"Nome: {animal.Nome}");
            Console.WriteLine($"Espécie: {animal.Especie}");
            Console.WriteLine($"Idade: {animal.Idade}");
            animal.EmitirSom(); // Chamada do método EmitirSom
        }
    }
}