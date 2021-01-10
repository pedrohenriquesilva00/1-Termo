using System;

namespace Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double limite;
            System.Console.Write("Insira um número limite para contar: ");
            limite = double.Parse(Console.ReadLine());

            for(int i = 0; i < limite; i++)
            {
                if(i %2 == 1) System.Console.WriteLine(i);
            }
        }
    }
}
