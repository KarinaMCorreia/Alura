using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _03_ByteBanck
{
    class Program
    {
        static void Main(string[] args)
        {
            // tipos de referência e de valor

            ContaCorrente contaDaKarina = new ContaCorrente();

                contaDaKarina.titular = "Karina Mendes";
                contaDaKarina.Agencia = 250;
                contaDaKarina.numero  = 45025002;
                contaDaKarina.saldo   = 150;


            ContaCorrente conta = new ContaCorrente();

                conta.titular = "Karina Mendes";
                conta.Agencia = 250;
                conta.numero = 45025002;
                conta.saldo = 150;

            Console.WriteLine("Igualdade de tipo de referencia: " + (contaDaKarina == conta));

                int idade = 26;
                int idadeDaKarina = 26;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeDaKarina));

 


                contaDaKarina = conta;
            Console.WriteLine(contaDaKarina == conta); 



            Console.ReadLine();



        }
    }
}
