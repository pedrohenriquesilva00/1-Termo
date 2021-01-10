using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(i);
            Console.ResetColor();
            }
        }
    }
}
