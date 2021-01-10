using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 3;
            string[] nomes = new string[j];
            System.Console.WriteLine("Ordem de nomes.");

            for(int i = 0; i < j; i++)
            {
                System.Console.WriteLine($"Insira o {+i +1} Nome: ");
                nomes[i] = Console.ReadLine();
            }

            Console.Clear();
            Array.Sort(nomes);
            int numero = 0;

            foreach(string item in nomes)
            {
                numero ++;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine($"{numero} - {item}");
                Console.ResetColor();
            }
        }
    }
}
