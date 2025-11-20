// Conceitos da Programação Orientada a Objetos: Herança        

using System;

class Program
{
    static void Main(string[] args)
    {
        Funcionarios funcionario = new Funcionarios();
        funcionario.Nome = "João Silva";
        funcionario.Email = "";
        funcionario.Empresa = "Tech Solutions";
        funcionario.Salario = "5000";

        funcionario.Indentificar();
    }

    public class Pessoas
    {
        public string? Nome;
        public string? Email;
        public void Indentificar()
        {
            Console.WriteLine($"Nome: {Nome}, Email: {Email}");
        }
    }

    public class Funcionarios : Pessoas
    {
        public string? Empresa { get; set; }
        public string? Salario { get; set; }
    }

    public class Alunos : Pessoas
    {
        public string? Curso { get; set; }
        public string? Matricula { get; set; }
    }

}