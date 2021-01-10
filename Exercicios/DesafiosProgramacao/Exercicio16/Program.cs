using System;

namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Índice de massa corporal");
            System.Console.WriteLine("Insira seu nome: ");
            string nome = (Console.ReadLine());
            System.Console.Write("Insira seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            System.Console.Write("Insira sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / (altura * altura);

            if (imc < 20) 
            {
                System.Console.WriteLine("Você está abaixo do peso: " + nome);
            } else if ((imc > 20) && (imc < 25)) {
                System.Console.WriteLine("Seu peso está normal: " + nome);
            } else if ((imc > 25) && (imc < 30)) {
                System.Console.WriteLine("Você está acima do peso: " + nome);
            } else if ((imc > 30) && (imc < 35)) {
                System.Console.WriteLine("Você está obeso: " + nome);
            } else if (imc > 35) 
            System.Console.WriteLine("Você está muito obeso: " + nome);
        }
    }
}
