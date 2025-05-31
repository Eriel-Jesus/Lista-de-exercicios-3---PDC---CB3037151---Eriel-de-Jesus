using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc3
{
    internal class Exerc3
    {
        static void Main(string[] args)
        {
            string sexo;

            do
            {
                Console.Clear();
                Console.Write("Insira o seu gênero,(F para Feminino / M para Masculino): ");
                sexo = Console.ReadLine();
            } while (sexo != "F" && sexo != "M");

            Console.Clear();
            if (sexo == "F")
            {
                Console.WriteLine("Entendi, então você é do gênero feminino!");
            }
            else
            {
                Console.WriteLine("Entendi, então você é do gênero masculino!");
            }
            Console.ReadKey();

        }
    }
}
