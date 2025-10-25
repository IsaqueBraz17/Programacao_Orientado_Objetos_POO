using System;

// Métodos - Sintaxe minima

// Tipo de retorno - Determina o tipo de dado que o método irá retornar
// Se o metod não retornar nenhum valor, o tipo de retorno deve ser "void"

// Nome do método - Deve ser um nome que descreva a ação que o método realiza

// Parâmetros - São valores que o método pode receber para realizar sua ação

//corpo do método - Bloco de código que define a ação que o método realiza

MinhaClasse minhaClasse = new MinhaClasse();
minhaClasse.Saudacao();
minhaClasse.ExibirDataAtual();

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Olá, Mundo!");
        ExibirDataAtual();
    }

    public void ExibirDataAtual()
    {
        Console.WriteLine(DateTime.Now.ToShortTimeString);
    }
}
