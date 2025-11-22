
interface IControle
{
    void Desenhar();

    public void Exibir()
    {
        System.Console.WriteLine("Exibindo o controle...");
    }
}

interface IGrafico
{
    void Pintar();
}

public class Demo : IControle, IGrafico
{
    public void Desenhar()
    {
        // Implementação do método Desenhar
        System.Console.WriteLine("Desenhando o controle...");
    }

    public void Pintar()
    {
        // Implementação do método Pintar
        System.Console.WriteLine("Pintando o gráfico...");
    }
}