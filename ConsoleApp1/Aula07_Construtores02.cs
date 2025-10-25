using System;

// Utilizando 2 construtores
public class Sou_Aluno
{
    // Campos
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Sexo { get; set; }
    public string? Aprovado { get; set; }

    // Construtor 1: apenas nome
    public Sou_Aluno(string nome) => Nome = nome;

    // Construtor 2: idade, sexo, aprovado
    public Sou_Aluno(string nome, int idade, string sexo, string aprovado) : this(nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }
}

// Exemplo de uso
class Aula07_Construtores02
{
    static void Main()
    {

        Sou_Aluno aluno1 = new Sou_Aluno("Isaque", 20, "Masculino", "Sim");
        Console.WriteLine($"Aluno 2: Nome = {aluno1.Nome},Idade = {aluno1.Idade}, Sexo = {aluno1.Sexo}, Aprovado = {aluno1.Aprovado}");
    }
}