using System;

namespace Exercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int coluna = 3;
            int fileira = 3;

            int valor;
            Random random = new Random();

            int[,] matrizes = new int[fileira,coluna];

            for(int i = 0; i < fileira; i++) 
            {
                for(int j = 0; j < coluna; j++) 
                {
                    valor = random.Next(100);
                    matrizes[i, j] = valor;
                    System.Console.WriteLine($"Fileira {i+1}; Coluna {j+1}: {valor}");
                }
            }
        }
    }
}
