using System;

namespace Exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int[] vetor = new int[10];
            Random random = new Random();
            for(int i = 0; i < vetor.Length; i++) vetor[i] = random.Next(1000);
            for(int i = 0; i < vetor.Length;i++) if (vetor[i] % 2 == 0) System.Console.WriteLine($"{i+1} - {vetor[i]} Par");
            System.Console.WriteLine();
            for(int i = 0; i < vetor.Length;i++) if (vetor[i] % 2 == 1) System.Console.WriteLine($"{i+1} - {vetor[i]} impar");
        }
    }
}
