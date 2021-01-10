using System;
using System.Linq;
using Treinamento.Interfaces;
using Treinamento.Models.Animais;

namespace Treinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var encerraPrograma = false;
            do
            {
                var codigo = 0;
                System.Console.WriteLine("Bem vindo!!");
                foreach (var item in ConjuntoAnimais.Animais.Values)
                {
                    System.Console.WriteLine($"{item.GetType().Name}");
                }
            } while (!encerraPrograma);
        }
    }
}
