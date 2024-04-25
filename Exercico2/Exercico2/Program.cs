namespace Exercico2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto compra = new Produto(1,"Celular",0,2330);

            compra.imprimir();
            compra.entrada(100);
            compra.imprimir();
            compra.venda(9);
            compra.imprimir();
        }
    }
}