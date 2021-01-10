using System;

namespace Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            int nVetores;

            Console.Clear();
            System.Console.WriteLine("Vetores");
            System.Console.Write("Insira a quantidade de vetores: ");
            nVetores = int.Parse(Console.ReadLine());
            int[] vetor = new int[nVetores];

            foreach(int numero in vetor) 
            {
                int index = Array.IndexOf(vetor, numero);
                System.Console.Write($"Insira o {index +1} numero: ");
                vetor[index] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
            for(int i = 0; i < vetor.Length; i++) System.Console.WriteLine($"{i+1}. {vetor[i]}");
        }
    }
}
