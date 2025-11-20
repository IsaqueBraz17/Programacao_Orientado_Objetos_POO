    using System;

    static class Program
    {
        static void Main()
        {
            ClassDerivada cd = new ClassDerivada();
            cd.Public_Membro();                // Acesso permitido (public)
            cd.Internal_Membro();              // Acesso permitido (internal - mesmo assembly)
            // cd.Protected_Membro();          // Acesso negado aqui (protected só é acessível em derivadas)
            // cd.Private_Membro();            // Acesso negado aqui (private)

            // Para demonstrar acesso a membros protegidos, use o método público da classe derivada:
            cd.AcessarMembros();
        }
    }

    public class ClassDerivada : ClasseBase
    {
        public void AcessarMembros()
        {
            Public_Membro();          // Acesso permitido (public)
            Protected_Membro();       // Acesso permitido (protected dentro da derivada)
            Internal_Membro();        // Acesso permitido (internal no mesmo assembly)
            // Private_Membro();      // Acesso negado - método privado da classe base
        }
    }

    public class ClasseBase
    {
        public void Public_Membro()
        {
            Console.WriteLine("Acesso ao membro público da Classe Base");
        }

        protected void Protected_Membro()
        {
            Console.WriteLine("Acesso ao membro protegido da Classe Base");
        }

        internal void Internal_Membro()
        {
            Console.WriteLine("Acesso ao membro interno da Classe Base");
        }

        private void Private_Membro()
        {
            Console.WriteLine("Acesso ao membro privado da Classe Base");
        }
    }
