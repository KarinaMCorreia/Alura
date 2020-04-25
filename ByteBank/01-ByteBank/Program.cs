using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Meu objeto contaCorrente 

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
           ContaCorrente contaDaKarina = new ContaCorrente();

            contaDaKarina.titular = "Karina Mendes";
            contaDaKarina.Agencia = 104;
            contaDaKarina.numero = 0212150511;
            contaDaKarina.saldo = 100;

                Console.WriteLine("Titular:"  + contaDaKarina.titular);
                Console.WriteLine("Agencia:"  + contaDaKarina.Agencia);
                Console.WriteLine("Numero: "  + contaDaKarina.numero);
                Console.WriteLine("Saldo:  "  + contaDaKarina.saldo);


                Console.ReadLine(); 

        }
    }
}
