/*Classes e Objetos */

Pessoa p1 = new Pessoa();
p1.Nome = "João";
p1.Idade = 25;
p1.Sexo = "Masculino";

Console.WriteLine($"Nome: {p1.Nome}, Idade: {p1.Idade}, Sexo: {p1.Sexo}");

Pessoa p2 = new Pessoa();
p2.Nome = "Maria";
p2.Idade = 18;
p2.Sexo = "Feminino";

Console.WriteLine($"Nome: {p2.Nome}, Idade: {p2.Idade}, Sexo: {p2.Sexo}");

/*Criando uma classe*/
class Pessoa
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
}

