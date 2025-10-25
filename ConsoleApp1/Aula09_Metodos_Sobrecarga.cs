using System;

Email email = new Email();
email.Enviar();



public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"Enviando email para {endereco}");
        Console.WriteLine("Email enviado com sucesso!");
    }

    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"Enviando email para {endereco}");
        Console.WriteLine($"{assunto}");
    }

    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine($"Enviando email para {endereco}");
        Console.WriteLine("Proposta de venda..");
        Console.WriteLine($" Envioando o valor:{valor}");
    }

    public void Enviar(decimal assunto, string endereco)
    {
        Console.WriteLine($"Enviando email para {endereco}");
        Console.WriteLine("Proposta de venda..");
        Console.WriteLine($" Envioando o assunto:{assunto}");
    }
}

