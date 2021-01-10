using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            do{
                Console.Write("Digite um número ou zero para parar: ");
                num = int.Parse(Console.ReadLine());

                if((num % 2) !=0){
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("O número é ímpar.");
                    Console.ResetColor();
                } else{
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("O número é par.");
                    Console.ResetColor();
                }
            
            } while (num != 0);
        }
    }
}
