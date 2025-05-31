using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc4
{
    internal class Exerc4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada do 5!!!");
            Console.WriteLine();
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("5 X {0} = {1}", i, 5 * i);
            }
            Console.WriteLine();
            Console.WriteLine("Simples, não?");
            Console.ReadKey();
        }
    }
}
