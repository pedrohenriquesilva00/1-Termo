using System;

namespace Exercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int maior = 0;
            int menor = 0;
            Random random = new Random();

            for (int i = 0; i < vetor.Length; i++) vetor[i] = random.Next(1000);
            maior = vetor[0];
            menor = vetor[0];

            for(int i = 0; i < vetor.Length; i++)
            if(vetor[i] > 0) {
                System.Console.WriteLine($"{i + 1} - {vetor[i]}");
            }

            foreach (int vet in vetor) {
                if (vet > maior) {
                    maior = vet;
                } else if (vet < menor) {
                    menor = vet;
                }
            }
            Console.WriteLine ($"O maior número da Array é: {maior}.");
            Console.WriteLine ($"O menor número da Array é: {menor}.");
        }
    }
}
