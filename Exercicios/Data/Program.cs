using System;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 0;
            int idade = 0;

            do{
                Console.Write("Diga em que ano você nasceu: ");
                ano = int.Parse(Console.ReadLine());
                if((ano > 2020) || (ano <0 )){
                    Console.WriteLine("Retardado, estamos em 2019 ainda, digite a data correta! ");
                }
            } while ((ano > 2020) || (ano <= 0));
            
            idade = 2019 - ano;

            if(idade < 3){
                Console.WriteLine("Recém-Nascido");
            } else if((idade >= 3) && (idade <= 11)) {
                Console.WriteLine("Criança");
            } else if((idade >= 12) && (idade <= 19)){
                Console.WriteLine("Adolescente");
            } else if ((idade >= 20) && (idade <= 65)){
                Console.WriteLine("Adulto");
            } else if (idade >= 65){
                Console.WriteLine("Idoso");
            }
        }
    }
}
