using System;

// Métodos com parametros

OutraClasse outraClasse = new OutraClasse();

var nomeCliente = "Isaque";
var dataHoje = DateTime.Now.ToShortDateString();

//Valores dos argumentos
outraClasse.Saudacao(nomeCliente, dataHoje);

public class OutraClasse
{
    // os parametros do metodo
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}
