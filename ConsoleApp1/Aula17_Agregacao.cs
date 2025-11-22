namespace 

Professor prof1 = new Professor { Nome = "Ana", Disciplina = "Matemática" };

public class Professor
{
   public string? Nome { get; set; }
   public string? Disciplina { get; set; }
}

internal class Despertamento
{
   public string? Nome { get; set; }
   private List<Professor>?  professores { get; set; }
}

public void IncluirProfessor(Professor professor)
{
  professores.Add(professor);
}

public void ListarProfessores()
{
  foreach (var professor in professores)
  {
    Console.WriteLine($"Nome: {professor.Nome}, Disciplina: {professor.Disciplina}");
  }
}