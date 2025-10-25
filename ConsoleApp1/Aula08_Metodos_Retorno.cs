using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao_Orientacao_Objetos
{
    internal class Aula08_Metodos_Retorno
    {
        Calculadora calc = new Calculadora();

        var valor = calc.Somar(10, 20);
    }

    public class Calculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}

