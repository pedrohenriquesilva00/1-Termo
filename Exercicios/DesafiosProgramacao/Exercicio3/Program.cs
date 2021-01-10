using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de tempo levou na viajem em horas: ");
            double temp = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a velocidade média em KM/H: ");
            double vel = double.Parse(Console.ReadLine());
            double dist = (temp * vel);
            Console.ForegroundColor = ConsoleColor.DarkGreen; //Troca a cor da fonte
            System.Console.WriteLine("A distância percorrida foi: " + dist);
            double cons = (dist / 12);
            System.Console.WriteLine("E o combustível gasto em litros foi de: " + cons);
            Console.ResetColor(); //Encerra a troca de cor da fonte
        }
    }
}
