using System;
using System.Collections.Generic;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Models
{
    public class Agendamento
    {
        public ulong Id {get; set;}
        public uint Status {get; set;}
        public Cliente Cliente {get; set;}
        public string TemaEvento {get; set;}
        public string TipoEvento {get; set;}
        public string Pacote {get; set;}
        public string Telefone {get; set;}
        public string Cnpj {get; set;}
        public string QuantidadePessoas {get; set;}
        public DateTime DataDoAgendamento {get; set;}
        public string DataDoEvento {get; set;}
        public Aluguel Aluguel {get; set;}
        public Servico Servicos {get; set;}
        public double PrecoTotal {get; set;}

        public Agendamento()
        {
            this.Cliente = new Cliente();
            this.Servicos = new Servico();
            this.Aluguel = new Aluguel();
            this.DataDoAgendamento = DateTime.Now;
        }
        public Agendamento(Cliente cliente, List<Servico> servicos, List<Aluguel> aluguel, string temaevento, string tipoevento, string pacote, string telefone, string cnpj, string quantidadepessoas)
        {
            this.TemaEvento = temaevento;
            this.TipoEvento = tipoevento;
            this.Telefone = telefone;
            this.Pacote = pacote;
            this.Cnpj = cnpj;
            this.QuantidadePessoas = quantidadepessoas;
            this.DataDoAgendamento = DateTime.Now;
            this.Status = (uint) StatusAgendamento.PENDENTE;
        }
    }
}