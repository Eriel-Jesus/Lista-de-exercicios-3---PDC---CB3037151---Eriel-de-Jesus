using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc7
{
    internal class Exerc7
    {
        static void Main(string[] args)
        {
            int numero = 1;

            for (int contador = 1; contador < 11; contador++) 
            {
                Console.WriteLine("Tabuada do {0}", numero);
                do
                {
                    Console.WriteLine("{0} X {1} = {2}", numero, contador, numero * contador);
                    contador++;
                } while (contador < 11);
                Console.ReadKey();
                if (numero == 20 && contador == 11)
                {
                    contador = 12;
                    Console.Clear();
                    Console.WriteLine("Isso é tudo, obrigado!");
                }
                else
                {
                    numero++;
                    contador = 0;
                    Console.Clear();
                }

            }
        }
    }
}
