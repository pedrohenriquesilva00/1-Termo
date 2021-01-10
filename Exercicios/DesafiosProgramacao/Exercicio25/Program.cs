using System;

namespace Exercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine ("Digite o limite do vetor 1: ");
            int limiteV1 = int.Parse(Console.ReadLine ());
            System.Console.WriteLine ("Digite o limite do vetor 2: ");
            int limiteV2 = int.Parse(Console.ReadLine ());

            int[] vetor1 = new int[limiteV1];
            int[] vetor2 = new int[limiteV2];

            Random random = new Random();

            for(int i = 0; i < vetor1.Length; i++) 
            {
                vetor1[i] = random.Next (0, 100);
            }
            for(int i = 0; i < vetor2.Length; i++) 
            {
                vetor2[i] = random.Next (0, 100);
            }

            int[] vetor3 = new int[limiteV1 + limiteV2];

            int count = 0;
            for(int i = 0; i < vetor1.Length; i++)
            {
                vetor3[i] = vetor1[i];
                count = i;
            }
            count += 1;
            for(int i = 0; i < vetor2.Length; i++)
            {
                vetor3[count] = vetor2[i];
                count++;
            }
            Console.Clear();
            
            System.Console.WriteLine("Vetor 1: ");
            
            foreach(int item in vetor1)
            {
                System.Console.Write(item + " ");
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine("Vetor 2: ");
            
            foreach(int item in vetor2)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Uniâo dos vetores: ");

            foreach(int item in vetor3)
            {
                System.Console.Write(item + " ");
            }
        }
    }
}
