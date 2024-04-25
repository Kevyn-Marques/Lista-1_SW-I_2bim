namespace ExemploConstrct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SALVE CRIA!");

            Cliente cliente= new Cliente(11,"Mano Limgas");


            cliente.Email = "seujão@gmail.com";
            cliente.Senha = 2345678;

            cliente.MostraDados();
        }
    }
}