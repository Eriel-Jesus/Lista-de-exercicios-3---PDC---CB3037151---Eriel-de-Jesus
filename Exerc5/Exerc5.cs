using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc5
{
    internal class Exerc5
    {
        static void Main(string[] args)
        {
            int i = 1;
            double valor;
            bool verifica;

            Console.Write("Insira o número de qual será a tabuada: ");
            verifica = double.TryParse(Console.ReadLine(), out valor);

            while (verifica == false || valor < 0)
            {
                Console.Clear();
                Console.Write("Insira corretamente o número de qual será a tabuada: ");
                verifica = double.TryParse(Console.ReadLine(), out valor);              
            }

            Console.Clear();
            Console.WriteLine("Tabuada do {0}!", valor);
            Console.WriteLine();
            do
            {
                Console.WriteLine("{0} X {1} = {2}", valor, i, valor * i);
                i++;
            } while (i < 11);
            Console.WriteLine();
            Console.WriteLine("Simples, não?");
            Console.ReadKey();
        }
    }
}
