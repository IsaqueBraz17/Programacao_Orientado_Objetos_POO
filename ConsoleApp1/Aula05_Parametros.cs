using System;

class Aula05_Parametros_Em_Classes
{
    static void Main(string[] args)
    {
        // Criando objetos das classes
        Aluno aluno = new Aluno();

        Console.WriteLine("Nome: ");
        aluno.Nome = Console.ReadLine();

        Console.WriteLine("Idade: ");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sexo: ");
        aluno.Sexo = Console.ReadLine();

        Console.WriteLine("Aprovado (S)im e (Não): ");
        aluno.Aprovado = Console.ReadLine();

        Curso curso = new();
        curso.Resultado(aluno);

        Console.ReadKey();
    }
}

// Classes
public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

// Classes com métodos e parâmetros
public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\nO aluno {aluno.Nome}, sexo {aluno.Sexo}, com idade {aluno.Idade} anos");
        if (aluno.Aprovado == "S")
        {
            Console.WriteLine("\n foi aprovado!!");
        }
        else
        {
            Console.WriteLine("\n foi Reprovado");
        }
    }
}