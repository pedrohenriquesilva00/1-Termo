using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            int a = 0;
            int b = 0;
            int c = 0;

            System.Console.WriteLine("Ordem crescente dos números.");
            System.Console.WriteLine("Digite o 1 número: ");
            a = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o 2 número: ");
            b = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o 3 número: ");
            c = int.Parse(Console.ReadLine());

            if((a > b) && (b > c))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine($"A ordem crescente dos números é: {c} {b} {a}");
                Console.ResetColor();
            } else if ((b > a) && (a > c)) {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine($"A ordem crescente dos números é: {c} {a} {b}");
                Console.ResetColor();
            } else if ((c > a ) && (a > b)) {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine($"A ordem crescente dos números é: {b} {a} {c}");
                Console.ResetColor();
            } else if ((b > c) && (c > a)) {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine($"A ordem crescente dos números é: {a} {c} {b}");
                Console.ResetColor();
            } else if ((a > c) && (c > b)) {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine($"A ordem crescente dos números é: {b} {c} {a}");
                Console.ResetColor();
            } else if ((c > b) && (b > a)) {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine($"A ordem crescente dos números é: {a} {b} {c}");
                Console.ResetColor();
            }
        }
    }
}
