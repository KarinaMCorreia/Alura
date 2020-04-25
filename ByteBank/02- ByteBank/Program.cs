using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02__ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

                conta.titular = "Filipe olivetti";

            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta.Agencia); 

            Console.ReadLine();



            





        }
    }
}
