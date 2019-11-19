using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praticando_char_e_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mão na massa: Praticando char e String");

            char letra = 'a';
            Console.WriteLine(letra);

            //tabela ascii
            char valor = (char)65;
            Console.WriteLine(valor);      // Compila!


            valor = (char)(valor + 1);   // complila! 
            Console.WriteLine(valor);

            string palavra = "alura cursos online de tecnologia";
            Console.WriteLine(palavra);


            palavra = palavra +  2020;
            Console.WriteLine(palavra);

            Console.ReadLine();

        }
    }
}
