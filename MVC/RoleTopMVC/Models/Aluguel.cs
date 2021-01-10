namespace RoleTopMVC.Models
{
    public class Aluguel
    {
        public string Nome {get; set;}
        public double Preco {get; set;}
        public Aluguel ()
        {

        }
        public Aluguel(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}