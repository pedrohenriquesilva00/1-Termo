using System;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meses = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio","Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};
            int intervalo = meses.Length;

            System.Console.WriteLine("Meses do ano");
            System.Console.Write("Insira um número do mês: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            
            if (index < intervalo) {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine($"Mês: {meses [index]}");
            Console.ResetColor();
            } else {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("Insira um número do mês valido!");
            Console.ResetColor();
            } 
        }
    }
}
