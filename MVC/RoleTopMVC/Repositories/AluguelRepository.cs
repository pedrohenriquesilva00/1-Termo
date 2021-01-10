using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class AluguelRepository
    {
        private const string PATH = "Database/Aluguel.csv";
        public double ObterPrecoDe(string nomeAluguel)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nomeAluguel))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }
        public List<Aluguel> ObterTodos()
        {
            List<Aluguel> alugueis = new List<Aluguel>();
            var linhas = File.ReadAllLines(PATH);

            foreach (var linha in linhas)
            {
                Aluguel a = new Aluguel();
                var dados = linha.Split(";");
                a.Nome = dados[0];
                a.Preco = double.Parse(dados[1]);

                alugueis.Add(a);
            }
            return alugueis;
        }
    }
}