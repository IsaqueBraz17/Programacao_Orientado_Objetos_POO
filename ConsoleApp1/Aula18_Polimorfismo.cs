using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    // EXPLICAÇÃO RÁPIDA (em código):
    // - Polimorfismo em C# tem duas formas principais:
    //   1) Polimorfismo de compilação (sobrecarga / overloading) — mesmo nome, assinaturas diferentes.
    //   2) Polimorfismo de execução (sobrescrita / overriding) — chamada resolvida em tempo de execução via virtual/override.
    //
    // Este arquivo mostra ambos com exemplos simples e um fluxo passo-a-passo.

    // --------------------------
    // 1) Polimorfismo de compilação (overload)
    // --------------------------
    public static class Calculadora
    {
        // Sobrecarga: mesmo método "Somar" com diferentes assinaturas
        public static int Somar(int a, int b) => a + b;
        public static double Somar(double a, double b) => a + b;
        public static int Somar(params int[] valores)
        {
            int s = 0;
            foreach (var v in valores) s += v;
            return s;
        }
    }

    // --------------------------
    // 2) Polimorfismo de execução (override)
    // --------------------------
    public abstract class Animal
    {
        public string Nome { get; }
        protected Animal(string nome) => Nome = nome;

        // Método abstrato: força implementação nas classes filhas
        public abstract void FazerSom();

        // Método virtual com implementação base que pode ser sobrescrita
        public virtual string Movimento() => "move-se de forma genérica";
    }

    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome) { }

        public override void FazerSom() => Console.WriteLine($"{Nome}: Au au!");

        public override string Movimento() => "corre e busca a bola";

        // Método específico da subclasse (não visível via referência Animal sem cast)
        public void Buscar() => Console.WriteLine($"{Nome} trouxe a bola.");
    }

    public class Gato : Animal
    {
        public Gato(string nome) : base(nome) { }

        public override void FazerSom() => Console.WriteLine($"{Nome}: Miau!");

        // usa a implementação padrão de Movimento (herdada) — poderia override se quisesse
    }

    public class Passaro : Animal
    {
        public Passaro(string nome) : base(nome) { }

        public override void FazerSom() => Console.WriteLine($"{Nome}: Piu piiu!");

        public override string Movimento() => "voa pelo céu";
    }

    // --------------------------
    // Programa demonstrativo (passo a passo)
    // --------------------------
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Polimorfismo em C# — Demo passo a passo ===");
            Console.WriteLine();

            // Parte A: Polimorfismo de compilação (overload)
            Console.WriteLine("-- Overload (compilação) --");
            Console.WriteLine($"Somar(int,int):  Somar(2,3) = {Calculadora.Somar(2, 3)}");
            Console.WriteLine($"Somar(double,double): Somar(1.5,2.4) = {Calculadora.Somar(1.5, 2.4)}");
            Console.WriteLine($"Somar(params int[]): Somar(1,2,3,4) = {Calculadora.Somar(1,2,3,4)}");
            Console.WriteLine();

            // Parte B: Polimorfismo de execução (override)
            Console.WriteLine("-- Override / Dispatch em tempo de execução --");
            // Upcasting: guardamos objetos derivados em referências do tipo base (Animal)
            List<Animal> animais = new List<Animal>
            {
                new Cachorro("Rex"),
                new Gato("Mimi"),
                new Passaro("Tico")
            };

            Console.WriteLine("Iterando lista de Animal e chamando FazerSom() e Movimento():");
            foreach (var a in animais)
            {
                // Chamadas resolvidas em tempo de execução na implementação override correta
                a.FazerSom();
                Console.WriteLine($"  Movimento: {a.Movimento()}");
            }
            Console.WriteLine();

            // Parte C: Downcast quando precisamos usar métodos específicos da subclasse
            Console.WriteLine("-- Downcast (uso de métodos específicos) --");
            Animal animalGenerico = new Cachorro("Bolinha"); // referência do tipo base
            animalGenerico.FazerSom(); // chama Cachorro.FazerSom() — polimorfismo

            // Para chamar Buscar() (método só do Cachorro) precisamos converter:
            if (animalGenerico is Cachorro cachorro)
            {
                cachorro.Buscar(); // agora podemos usar o método específico
            }

            // Exemplo com 'as' e verificação nula
            Animal talvezGato = new Gato("Nina");
            var gato = talvezGato as Gato;
            gato?.FazerSom();

            Console.WriteLine();
            Console.WriteLine("=== Fim da demonstração ===");
            Console.WriteLine("Pressione Enter para sair...");
            Console.ReadLine();
        }
    }
}