using System;

namespace Exercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3 = new int[10];

            for(int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"Entre com o {i + 1} número do Primeiro vetor: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"Entre com o {i + 1} número do Segundo vetor: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < vetor1.Length; i++) 
            {
                vetor3[i] = vetor1[i] + vetor2[i];
                System.Console.WriteLine("A soma dos vetores é: " + vetor3[i]);
            }
        }
    }
}
