using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {

            float pontoFlutuante = 3.15f;
            Console.WriteLine(pontoFlutuante);

            double salario = 1270.50;
            int valor = (int)salario; 

            Console.WriteLine(valor);

            double valor1 = 1.0;
            double valor2 = 1.6;
            double total = valor1 + valor2;

            Console.WriteLine(total);

         
        }
    }
}
