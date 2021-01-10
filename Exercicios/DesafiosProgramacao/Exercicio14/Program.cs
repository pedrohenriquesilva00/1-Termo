using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string[] termina = {"r","res","r","rmos","ndes","rem"};

            System.Console.WriteLine("Verbo no infinitivo");
            System.Console.Write("Insira um verbo no infinitivo: ");
            string palavra = Console.ReadLine().ToLower();
            
            int index = 0;
            foreach(string sufixo in termina) 
            {
                if (palavra.EndsWith(sufixo)) break;
                index++;
            }
            if (index == 6) 
            {
                System.Console.WriteLine("Verbo não está no infinitivo");
            } else 
            {
                if (palavra.EndsWith("a" + termina[index])) System.Console.WriteLine("Primeira Conjugaçao");
                else if (palavra.EndsWith("e" + termina[index])) System.Console.WriteLine("Segunda Conjugaçao");
                else if (palavra.EndsWith("i" + termina[index])) System.Console.WriteLine("Terceira Conjugaçao");
            }
        }
    }
}
