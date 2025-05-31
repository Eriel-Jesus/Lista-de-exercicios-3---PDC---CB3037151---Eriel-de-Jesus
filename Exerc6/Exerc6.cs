using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc6
{
    internal class Exerc6
    {
        static void Main(string[] args)
        {
            int i = 1;
            int maior, menor;
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

            Console.Write("Por onde a tabuada deve começar? ");
            verifica = int.TryParse(Console.ReadLine(), out menor);

            while (verifica == false || menor < 0)
            {
                Console.Clear();
                Console.Write("Insira por onde a tabuada deve começar: ");
                verifica = int.TryParse(Console.ReadLine(), out menor);
            }
            Console.Clear();

            Console.Write("Em qual múltiplo a tabuada deve terminar: ");
            verifica = int.TryParse(Console.ReadLine(), out maior);

            while (verifica == false || maior < menor)
            {
                Console.Clear();
                Console.Write("Insira em qual múltiplo a tabuada deve encerrar: ");
                verifica = int.TryParse(Console.ReadLine(), out maior);
            }


            Console.Clear();
            Console.WriteLine("Tabuada do {0}!", valor);
            Console.WriteLine();
            i = menor;
            do
            {
                Console.WriteLine("{0} X {1} = {2}", valor, i, valor * i);
                i++;
            } while (i < (maior + 1));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
