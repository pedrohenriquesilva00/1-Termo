using System;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double[] numeros = new double[3];
            System.Console.WriteLine("*** Verificador de Triangulos ***");
            for(int i = 0; i<3; i++) 
            {
                System.Console.WriteLine($"Insira o {i+1}º número");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            
            double lado1 = numeros[0];
            double lado2 = numeros[1];
            double ladoMaior = numeros[2];

            if(ladoMaior<lado1+lado2)
            {
                if (lado1==lado2 && lado1!=ladoMaior && lado2!=ladoMaior) System.Console.WriteLine("Esse é um triangulo isosceles");
                else if (lado1==lado2 && lado1==ladoMaior && lado2==ladoMaior) System.Console.WriteLine("Esse é um triangulo equilatero");
                else System.Console.WriteLine("Esse é um triangulo escaleno");
            } else System.Console.WriteLine("Esse não é triangulo");

        }
    }
}
