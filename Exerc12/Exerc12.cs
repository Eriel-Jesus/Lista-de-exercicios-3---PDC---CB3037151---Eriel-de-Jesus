using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc12
{
    internal class Exerc12
    {
        static void Main(string[] args)
        {
            string continuar;
            do
            {
                Console.Clear();
            int N;

            Console.Write("Digite a quantidade de valores (entre 1 e 19): ");
            N = int.Parse(Console.ReadLine());

            while (N <= 0 || N >= 20)
            {
                Console.Write("Valor inválido, insira novamente (entre 1 e 19): ");
                N = int.Parse(Console.ReadLine());
            }

            int[] valores = new int[N];
            int maior = int.MinValue, menor = int.MaxValue, soma = 0;
            int positivos = 0, negativos = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite o " + (i + 1) + "° valor: ");
                valores[i] = int.Parse(Console.ReadLine());
                soma += valores[i];

                if (valores[i] > maior) maior = valores[i];
                if (valores[i] < menor) menor = valores[i];

                if (valores[i] > 0) positivos++;
                else negativos++;
            }

            double media = soma / N;
            double percPositivos = positivos * 100.0 / N;
            double percNegativos = negativos * 100.0 / N;

            Console.WriteLine("Maior valor: " + maior);
            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Soma dos valores: " + soma);
            Console.WriteLine("Média aritmética: " + media.ToString("F2"));
            Console.WriteLine("Percentual de positivos: " + percPositivos.ToString("F2") + "%");
            Console.WriteLine("Percentual de negativos: " + percNegativos.ToString("F2") + "%");

            Console.Write("Deseja executar novamente? (S/N): ");
            continuar = Console.ReadLine().ToUpper();

            } while (continuar == "S");
        }
    }
}
