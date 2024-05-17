namespace EX_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            int opcao;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Adicionar pessoa");
                Console.WriteLine("2. Remover pessoa");
                Console.WriteLine("3. Buscar pessoa");
                Console.WriteLine("4. Imprimir agenda");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Nome da pessoa: ");
                        string nome = Console.ReadLine();
                        Console.Write("Idade da pessoa: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Altura da pessoa: ");
                        float altura = float.Parse(Console.ReadLine());
                        agenda.ArmazenaPessoa(nome, idade, altura);
                        break;
                    case 2:
                        Console.Write("Nome da pessoa a ser removida: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemovePessoa(nomeRemover);
                        break;
                    case 3:
                        Console.Write("Nome da pessoa a ser buscada: ");
                        string nomeBuscar = Console.ReadLine();
                        Pessoa pessoaBuscada = agenda.BuscaPessoa(nomeBuscar);
                        if (pessoaBuscada != null)
                        {
                            Console.WriteLine("Pessoa encontrada: " + pessoaBuscada);
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada na agenda.");
                        }
                        break;
                    case 4:
                        agenda.ImprimeAgenda();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Escolha uma opção válida.");
                        break;
                }
            } while (opcao != 0);
        }
    }
}