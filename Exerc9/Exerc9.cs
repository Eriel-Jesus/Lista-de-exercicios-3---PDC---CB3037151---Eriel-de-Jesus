using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroatual = 1, numeroseguinte = 1;

            Console.WriteLine("Sequência de Fibonacci (até o 30° valor):");
            for (int i = 0; i < 30; i++)
            {              
                Console.WriteLine(numeroatual);
                Console.ReadKey();
                numeroseguinte = numeroatual + numeroseguinte;
                numeroatual = numeroseguinte - numeroatual;
            }
            Console.WriteLine("Até hoje não entendi para que serve essa série de números...");
            Console.ReadKey();
        }
    }
}
