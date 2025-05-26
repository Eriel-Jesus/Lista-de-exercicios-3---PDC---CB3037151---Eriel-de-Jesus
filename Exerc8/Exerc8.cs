using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc8
{
    internal class Exerc8
    {
        static void Main(string[] args)
        {
            int numero = 1;

            for (int i = 2; i < 101; i++)
            {
                numero = numero + i;
                Console.WriteLine("{0} + {1} = {2}", numero - i, i, numero);
                Console.ReadKey();
            }
            Console.WriteLine();
            Console.WriteLine("Creio que seja o fim.");
            Console.ReadKey();
        }
    }
}
