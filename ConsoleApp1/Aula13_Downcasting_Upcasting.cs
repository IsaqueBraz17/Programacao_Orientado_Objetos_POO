using System;

static class Program
{
    static void Main()
    {
        // Upcasting: ClasseDerivada para ClasseBase
        ClasseBase objBase = new ClassDerivada();

        // Downcasting: ClasseBase para ClasseDerivada
        ClassDerivada objDerivada = (ClassDerivada)objBase;
        objDerivada.MetodoDerivada();

        // Usando 'as' para downcasting seguro
        ClasseBase outraBase = new ClasseBase();
        ClassDerivada outraDerivada = outraBase as ClassDerivada;


    }
}