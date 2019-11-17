using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto  3 Criando variáveis ponto flutuante");

            double salario;
            salario = 3000.00;
            Console.WriteLine(salario );

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine("15.0 / 2 = " + idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            Console.WriteLine("A execução acabou. Tecle enter para sair...");
            Console.ReadLine();

        }
    }
}
