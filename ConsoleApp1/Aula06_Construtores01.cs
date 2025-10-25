using System;

// Construtores
// São tipos especiais de métodos

Produtos produtos = new Produtos("Notebook", "Eletronico", 22, 3000);

Console.WriteLine(produtos.Nome == null ? "null" : produtos.Nome);
Console.WriteLine(produtos.Tipo == null ? "null" : produtos.Tipo);
Console.WriteLine(produtos.Quantidade == null ? "null" : produtos.Quantidade);
Console.WriteLine(produtos.Valor == null ? "null" : produtos.Valor);


public class Produtos
{
    public Produtos(string nome, string tipo, int quantidade, double valor)
    {
        Nome = nome;
        Tipo = tipo;
        Quantidade = quantidade;
        Valor = valor;

    }

    public string? Nome;
    public string? Tipo;
    public int? Quantidade;
    public double? Valor;

}