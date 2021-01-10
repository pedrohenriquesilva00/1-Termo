using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            double gravMe = 0.37;
            double gravVe = 0.88;
            double gravMa = 0.38;
            double gravJu = 2.64;
            double gravSa = 1.15;
            double gravUr = 1.17;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("1 Mercúrio");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine("2 Vênus");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("3 Marte");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            System.Console.WriteLine("4 Júpiter");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("5 Saturno");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("6 Urano");
            Console.ResetColor();
            opcao = (Console.ReadLine());

            switch(opcao) {
                case "1":
                System.Console.WriteLine("Digite o peso em Kilos: ");
                double pesoT1 = double.Parse(Console.ReadLine());
                double pesoM = (pesoT1 /10) * gravMe;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                System.Console.WriteLine("O peso em Mercúrio é: " + pesoM);
                Console.ResetColor();
                break;
                case "2":
                System.Console.WriteLine("Digite o peso em Kilos: ");
                double pesoT2 = double.Parse(Console.ReadLine());
                double pesoVe = (pesoT2 /10) * gravVe;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.WriteLine("O peso em Vênus é: " + pesoVe);
                Console.ResetColor();
                break;
                case "3":
                System.Console.WriteLine("Digite o peso em Kilos: ");
                double pesoT3 = double.Parse(Console.ReadLine());
                double pesoMa = (pesoT3 / 10) * gravMa;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine("O peso em Marte é: " + pesoMa);
                Console.ResetColor();
                break;
                case "4":
                System.Console.WriteLine("Digite o peso em Kilos: ");
                double pesoT4 = double.Parse(Console.ReadLine());
                double pesoJu = (pesoT4 / 10) * gravJu;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                System.Console.WriteLine("O peso em Júpiter é: " + pesoJu);
                Console.ResetColor();
                break;
                case "5":
                System.Console.WriteLine("Digite o peso em Kilos: ");
                double pesoT5 = double.Parse(Console.ReadLine());
                double pesoSa = (pesoT5 / 10) * gravSa;
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("O peso em Saturno é: " + pesoSa);
                Console.ResetColor();
                break;
                case "6":
                System.Console.WriteLine("Digite o peso em Kilos: ");
                double pesoT6 = double.Parse(Console.ReadLine());
                double pesoUr = (pesoT6 / 10) * gravUr;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine("O peso em Urano é: " + pesoUr);
                Console.ResetColor();
                break;
            }
        }
    }
}
