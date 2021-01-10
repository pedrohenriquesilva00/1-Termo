using System;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double salario;
            double bonus;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Olá funcionários da empresa Agora vai! Hoje daremos um aumento de 30% para alguns funcionários!");
            Console.Write("Digite seu salário aqui, e descubra se faz parte desse reajuste: ");
            Console.ResetColor();
            salario = double.Parse(Console.ReadLine());

            double aumento30p;

            aumento30p = (salario * 0.3) + salario;
            bonus = (1500);

            if ( salario >= 20000){
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Você não faz parte do reajuste. Continue trabalhando para futuramente ganhar um aumento!! ");
                Console.ResetColor();
            }  else {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Você faz parte do reajuste.");
                Console.WriteLine($" Seu salário será de R$:{salario * 0.3 + salario + bonus }");
                Console.ResetColor();
            }
        }
    }
}