using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;

            Console.WriteLine("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            C = A;
            A = B;
            B = C;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("O valor de A é: " + A);
            System.Console.WriteLine("O valor de B é: " + B);
            Console.ResetColor();
        }
    }
}
