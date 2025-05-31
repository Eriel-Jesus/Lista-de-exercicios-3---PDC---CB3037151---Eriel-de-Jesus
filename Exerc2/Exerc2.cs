using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc2
{
    internal class Exerc2
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;

            Console.Write("Insira o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            do
            {
                Console.Clear();
                Console.WriteLine("Primeiro valor: " + valor1);
                Console.Write("Insira agora o segundo valor (maior que o primeiro): ");
                valor2 = double.Parse(Console.ReadLine());

            } while (valor2 < valor1);

            Console.Clear();
            Console.WriteLine("Primeiro valor: " + valor1);
            Console.WriteLine("Segundo valor: " + valor2);
            Console.ReadKey();
        }
    }
}
