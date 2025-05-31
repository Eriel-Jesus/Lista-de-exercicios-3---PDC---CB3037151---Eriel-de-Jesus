using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1
{
    internal class Exerc1
    {
        static void Main(string[] args)
        {
            double valor1;

            do
            {
                Console.Clear();
                Console.Write("Insira um valor positivo: ");
                valor1 = double.Parse(Console.ReadLine());
            } while (valor1 < 0);
            Console.WriteLine("Valor inserido: " + valor1);
            Console.ReadKey();

        }
    }
}
