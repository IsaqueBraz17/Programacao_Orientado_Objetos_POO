using System;

public abstract class Forma
{
    public abstract class Forma
    {
        public string Cor { get; set; }
        public double Area { get; protected set; }
        public double Perimetro { get; protected set; }

    }
}
public class Quadrado : Forma
{
    public double Lado { get; set; }

    public override void CalcularArea() => Area = Lado * Lado;
    public override void CalcularPerimetro() => Perimetro = 4 * Lado;


    public override void CalcularPerimetro()
    {
        Perimetro = 4 * Lado;
    }

}

Quadrado quadrado = new Quadrado();
Console.WriteLine(quadrado.Descricao());

Console.WriteLine("Digite a cor do quadrado:");
quadrado.Cor = Console.ReadLine();

Console.WriteLine("informa o valor do lado do quadrado");
quadrado.Lado = Convert.ToDouble(Console.ReadLine());

quadrado.CalcularArea();
quadrado.CalcularPerimetro();

Console.WriteLine($"área do quadrado{quadrado.Area}");
Console.WriteLine($"perímetro do quadrado{quadrado.Perimetro}");

Console.WriteLine($"O quadrado tem cor: {quadrado.Cor}")

Console.ReadLine();
