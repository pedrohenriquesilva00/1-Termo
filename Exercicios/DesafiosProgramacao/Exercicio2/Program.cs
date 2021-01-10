using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite a temperatura: ");
            double TC = double.Parse(Console.ReadLine());
            double TF = (TC / 5) * 9 + 32;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("A temperatura em Fahrenheit é: " + TF);
            Console.ResetColor();
        }
    }
}
