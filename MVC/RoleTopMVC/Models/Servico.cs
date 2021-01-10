namespace RoleTopMVC.Models
{
    public class Servico
    {
        public string Nome {get; set;}
        public double Preco {get; set;}
        public Servico()
        {

        }
        public Servico(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}