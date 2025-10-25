public class Cachorro
{
    public string? Nome;
    public string? Raca;
    public int Idade;

    public void Latir()
    {
        Console.WriteLine("Au Au");
    }
    public void Comer()
    {
        Console.WriteLine($"{Nome} está comendo");
    }
};

Cachorro Biliu = new Cachorro();
Biliu.Nome = "Biliu";
Biliu.Raca = "Vira Lata";
Biliu.Idade = 3;

Console.WriteLine($"Nome: {Biliu.Nome}, Raça: {Biliu.Raca}, Idade: {Biliu.Idade}");

