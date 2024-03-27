using System;

namespace DescontoProdutoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do produto:");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto:");
            double precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do produto:");
            int quantidadeProduto = int.Parse(Console.ReadLine());
            Produto produto = new Produto(nomeProduto, precoProduto, quantidadeProduto);
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(produto);
            Console.WriteLine(new string('-', 40));
        }
    }
}