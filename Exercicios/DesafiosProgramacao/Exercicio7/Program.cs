using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i+= 2) {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(i);
            Console.ResetColor();
            }
        }
    }
}
