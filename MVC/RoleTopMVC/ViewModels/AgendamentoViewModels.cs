using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class AgendamentoViewModels : BaseViewModel
    {
        public List<Servico> Servicos {get; set;}
        public List<Aluguel> Alugueis {get; set;}
        public Cliente Cliente {get; set;}
        public string NomeCliente {get; set;}

        public AgendamentoViewModels()
        {
            this.Servicos = new List<Servico>(); 
            this.Alugueis = new List<Aluguel>();
            this.Cliente = new Cliente();
            this.NomeCliente = "";
        }
    }
}