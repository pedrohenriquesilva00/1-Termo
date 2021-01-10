using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            Console.Write("Entre com a Primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a Segunda nota :");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a Terceia nota: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a Q uarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("Sua média é: " + media);

            if ( media > 7){
                Console.WriteLine("Muito bem, você foi Aprovado");
            }  else if (media >= 7) {
                Console.WriteLine("Aeeee... Passou na casca né!");
            }  else {
                Console.WriteLine("Reprovado, seu burro");
            }
        }
    }
}
