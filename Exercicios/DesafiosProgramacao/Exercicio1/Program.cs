using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Calcula a área do Retângulo.
            System.Console.WriteLine("Bem vindo a: Medidas do Retângulo");
            System.Console.WriteLine("Digite a Base do Retângulo: ");
            double basRet = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a Altura do Retângulo: ");
            double altRet = double.Parse(Console.ReadLine());
            #endregion

            #region Calcula o Perímetro do Retângulo
            System.Console.WriteLine("Agora digite o comprimento do Retângulo: ");
            double compRet = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite também a Largura do Retângulo: ");
            double larRet = double.Parse(Console.ReadLine());
            #endregion

            Console.Clear();
            #region Imprimi na tela as medidas solicitadas ao usuário
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            double areaRet = (basRet * altRet);
            Console.WriteLine("A área do Retângulo é: " + areaRet);
            double periRet = (compRet + larRet) *2;
            System.Console.WriteLine("O perímetro do Retãngulo é: " + periRet);
            double diagRet = Math.Sqrt ((basRet * basRet) + (altRet * altRet));
            System.Console.WriteLine("A diagonal do Retângulo é: " + diagRet);
            Console.ResetColor();
            #endregion
        }
    }
}
