using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerci13
{
    internal class Exerc13
    {
        static void Main(string[] args)
        {
            string repetir;
            do
            {
                long valor;
                do
                {
                    Console.Clear();
                    Console.Write("Digite um valor não-negativo para calcular o fatorial: ");
                    valor = long.Parse(Console.ReadLine());
                    while (valor <= 0)
                    {
                        Console.WriteLine("Valor inválido. Digite novamente.");
                        valor = long.Parse(Console.ReadLine());
                    }

                    } while (valor < 0);

                long fatorial = 1;
                string formula = "";

                for (long i = valor; i >= 1; i--)
                {
                    fatorial *= i;
                    formula = i.ToString();
                    Console.Write(formula);
                    if (i > 1)
                    {
                        formula = " X ";
                        Console.Write(formula);
                    }

                }
                Console.WriteLine();
                Console.WriteLine(valor + "! = " + fatorial);
                    Console.Write("Deseja calcular outro fatorial? (S/N): ");
                    repetir = Console.ReadLine().ToUpper();
            } while (repetir == "S");
        }
    }
}
