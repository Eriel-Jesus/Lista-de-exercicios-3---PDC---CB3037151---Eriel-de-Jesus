using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerci10
{
    internal class Exerc10
    {
        static void Main(string[] args)
        {
            int[] valores = new int[10];
            int maior = 0, soma = 0;

            for (int i = 0; i < 10; i++)
            {
                int valor;
                do
                {
                    Console.Write("Digite o "+ (i+1) +" º valor positivo: ");
                    valor = int.Parse(Console.ReadLine());
                    if (valor <= 0)
                        Console.WriteLine("Valor inválido. Digite novamente: ");
                } while (valor <= 0);

                valores[i] = valor;
                soma += valor;
                if (valor > maior)
                    maior = valor;
            }

            double media = soma / 6.0;
            Console.WriteLine("Maior valor: " + maior);
            Console.WriteLine("Soma dos valores: " + soma);
            Console.WriteLine("Média aritmética: " + media.ToString("F2"));
        }
    }
}
