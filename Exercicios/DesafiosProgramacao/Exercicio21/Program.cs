using System;

namespace Exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double[] notas = {100, 50, 20, 10, 5, 2, 1};
            int[] numeroNotas = new int[notas.Length];
            System.Console.WriteLine("Caixa Eletrônico");
            System.Console.Write("Que valor você quer sacar? ");
            double valor = double.Parse(Console.ReadLine());

            int index = 0;
            
            do {
                valor = Math.Round(valor, 5);
                if (valor >= notas[index]) 
                {
                    valor = valor - notas[index];
                    numeroNotas[index] = numeroNotas[index] + 1;
                }
                if (valor < notas[index]) index++;
            }while(valor!=0);

            for(int i = 0; i < numeroNotas.Length; i++) if (numeroNotas[i] != 0) 
            System.Console.WriteLine($"Notas de {notas[i]}: {numeroNotas[i]}");
        }
    }
}
