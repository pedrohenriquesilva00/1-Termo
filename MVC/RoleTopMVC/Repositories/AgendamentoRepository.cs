using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class AgendamentoRepository : RepositoryBase
    {
        private const string PATH = "Database/Eventos.csv";
        public AgendamentoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Agendamento agendamento)
        {
            var quantidadeEventos = File.ReadAllLines(PATH).Length;
            agendamento.Id = (ulong) quantidadeEventos + 1;
            var linha = new string[] {PrepararAgendamentoCSV(agendamento)};
            File.AppendAllLines(PATH, linha);
            return true;
        }

        public List<Agendamento> ObterTodosPorCliente(string emailCliente)
        {
            var eventos = ObterTodos();
            List<Agendamento> eventosCliente = new List<Agendamento>();
            foreach (var evento in eventos)
            {
                if(evento.Cliente.Email.Equals(emailCliente))
                {
                    eventosCliente.Add(evento);
                }
            }
            return eventosCliente;
        }

        public List<Agendamento> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Agendamento> eventos = new List<Agendamento>(); 

            foreach (var linha in linhas)
            {
                Agendamento evento = new Agendamento();

                evento.Id = ulong.Parse(ExtrairValorDoCampo("evento_id", linha));
                evento.Status = uint.Parse(ExtrairValorDoCampo("status_agendamento", linha));
                evento.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                evento.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                evento.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                evento.Cnpj = ExtrairValorDoCampo("cnpj", linha);
                evento.TemaEvento = ExtrairValorDoCampo("tema_evento", linha);
                evento.TipoEvento = ExtrairValorDoCampo("tipo_evento", linha);
                evento.QuantidadePessoas = ExtrairValorDoCampo("quantidade_pessoas", linha);
                evento.DataDoEvento = ExtrairValorDoCampo("data_evento", linha);
                evento.Aluguel.Nome = ExtrairValorDoCampo("aluguel_nome", linha);
                evento.Aluguel.Preco = double.Parse(ExtrairValorDoCampo("aluguel_preco", linha));
                evento.Servicos.Nome = ExtrairValorDoCampo("servico_nome", linha);
                evento.Servicos.Preco = double.Parse(ExtrairValorDoCampo("servico_preco", linha));
                evento.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));
                eventos.Add(evento);
            }
            return eventos;
        }
        public Agendamento ObterPor(ulong id)
        {
            var eventosTotais = ObterTodos();
            foreach (var eventos in eventosTotais)
            {
                if(id.Equals(eventos.Id))
                {
                    return eventos;
                }
            }
            return null;
        }
        public bool Atualizar(Agendamento agendamento)
        {
            var eventosTotais = File.ReadAllLines(PATH);
            var agendamentoCSV = PrepararAgendamentoCSV(agendamento);
            var linhaAgendamento = -1;
            var resultado = false;
            
            for (int i = 0; i < eventosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("evento_id", eventosTotais[i]));
                if(agendamento.Id.Equals(idConvertido))
                {
                    linhaAgendamento = i;
                    resultado = true;
                    break;
                }
            }

            if(resultado)
            {
                eventosTotais[linhaAgendamento] = agendamentoCSV;
                File.WriteAllLines(PATH, eventosTotais);
            }

            return resultado;
        }
        private string PrepararAgendamentoCSV(Agendamento agendamento)
        {
            Cliente cliente = agendamento.Cliente;
            return $"evento_id={agendamento.Id};status_agendamento={agendamento.Status};cliente_nome={agendamento.Cliente.Nome};cliente_telefone={agendamento.Cliente.Telefone};cliente_email={agendamento.Cliente.Email};cnpj={agendamento.Cnpj};tema_evento={agendamento.TemaEvento};tipo_evento={agendamento.TipoEvento};quantidade_pessoas={agendamento.QuantidadePessoas};data_evento={agendamento.DataDoEvento};aluguel_nome={agendamento.Aluguel.Nome};aluguel_preco={agendamento.Aluguel.Preco};servico_nome={agendamento.Servicos.Nome};servico_preco={agendamento.Servicos.Preco};preco_total={agendamento.PrecoTotal};";
        }
    }
}