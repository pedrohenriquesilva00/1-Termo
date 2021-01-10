using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;

            System.Console.WriteLine("Digite a altura do Triângulo: ");
            altura = int.Parse(Console.ReadLine());

                for (int i = 0; i <= altura; i++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    System.Console.WriteLine(new string ('*', altura -i));
                    Console.ResetColor();
                }
        }
    }
}
