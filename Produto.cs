using System;

namespace DescontoProdutoOO
{
    class Produto
    {
        public string Nome;
        public double PrecoUnitario;
        public int Quantidade;

        public Produto(string nome, double precoUnitario, int quantidade)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
        }

        public double PrecoTotal()
        {
            double desconto = CalcularDesconto(Quantidade);
            return PrecoUnitario * Quantidade * (1 - desconto);
        }

        public double Desconto()
        {
            return CalcularDesconto(Quantidade);
        }

        public void ImprimirPrecoComDesconto()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Valor total: {PrecoTotal().ToString("C")}");
            Console.WriteLine($"Desconto: {Desconto().ToString("P")}");
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nPreço unitário: {PrecoUnitario.ToString("C")}\nQuantidade: {Quantidade}";
        }

        public static double CalcularDesconto(int quantidade)
        {
            if (quantidade > 50)
                return 0.25;
            else if (quantidade > 20)
                return 0.2;
            else if (quantidade > 10)
                return 0.1;
            else
                return 0;
        }
    }
}
