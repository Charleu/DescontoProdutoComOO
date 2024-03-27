using System;

namespace DescontoProdutoOO
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        public int Quantidade { get; set; }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public double PrecoTotal()
        {
            double precoTotal = _preco * Quantidade;
            double desconto = CalcularDesconto();
            return precoTotal * (1 - desconto);
        }

        private double CalcularDesconto()
        {
            if (Quantidade > 50)
                return 0.25;
            else if (Quantidade > 20)
                return 0.2;
            else if (Quantidade > 10)
                return 0.1;
            else
                return 0;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            _preco = preco;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nPreço unitário: {_preco.ToString("C")}\nQuantidade: {Quantidade}\nDesconto: {CalcularDesconto():P}\nValor total com desconto: {PrecoTotal().ToString("C")}";
        }
    }
}