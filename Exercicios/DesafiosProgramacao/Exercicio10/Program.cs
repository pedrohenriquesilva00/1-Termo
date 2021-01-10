using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if(num % 3 ==0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine("O número é multiplo de 3.");
                Console.ResetColor();
            } else {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine("O número não é multiplo de 3.");
                Console.ResetColor();
            }
        }
    }
}
