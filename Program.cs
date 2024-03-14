using System;

namespace DescontoProdutoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            string sep = new string('-', 40);
            Console.WriteLine("Informe o nome do produto:");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto:");
            double precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do produto:");
            int quantidadeProduto = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nomeProduto, precoProduto, quantidadeProduto);

            Console.WriteLine(sep);
            Console.WriteLine($"Valor total: {produto.PrecoTotal.ToString("C")}");
            Console.WriteLine(sep);
            Console.WriteLine($"Desconto: {produto.Desconto.ToString("C")}");
            Console.WriteLine(sep);
        }
    }
}