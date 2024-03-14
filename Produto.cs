using System;
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
        return CalcularPrecoTotal(PrecoUnitario, Quantidade);
    }

    public double Desconto()
    {
        return CalcularDesconto(Quantidade);
    }

    public void ImprimirDetalhes()
    {
        Console.WriteLine($"Valor total: {PrecoTotal().ToString("C")}");
        Console.WriteLine($"Desconto: {Desconto().ToString("C")}");
    }

    public static double CalcularPrecoTotal(double preco, int quantidade)
    {
        double desconto = CalcularDesconto(quantidade);
        return preco * quantidade * (1 - desconto);
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