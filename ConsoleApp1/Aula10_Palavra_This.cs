using System;

public class Cliente
{
    public string? Nome;
    public int? Idade;

    public Cliente(string? Nome, int Idade)
    {
        this.Nome = Nome;
        this.Idade = Idade;
    }
}

public class Teste
{
    public int num1;
    public int num2;

    public void PassarParametro(Teste t)
    {
        Console.WriteLine($"\nthis = {this}");
        Console.WriteLine("Num1: " + t.num1);
        Console.WriteLine("Num2: " + t.num2);
    }

    public void Exibir()
    {
        PassarParametro(this);
    }
}

public class Testando
{
    public Testando(int num1, int num2)
    {
        Console.WriteLine($"\nConstrutor com dois parâmetros: {num1} e {num2}");
    }

    public Testando(int num) : this(777, 888)
    {
        Console.WriteLine("\nConstrutor com um parâmetro: " + num);
    }
}

public class Aula08_Palavra_This
{
    public static void Main()
    {
        // Exemplo com Teste
        Teste t1 = new Teste();
        t1.num1 = 10;
        t1.num2 = 20;
        t1.Exibir();

        Teste t2 = new Teste();
        t2.num1 = 30;
        t2.num2 = 50;
        t2.Exibir();

        // Exemplo com Testando
        Testando test1 = new Testando(999);
    }
}