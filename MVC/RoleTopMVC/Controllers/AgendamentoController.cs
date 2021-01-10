using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class AgendamentoController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        ServicoRepository servicoRepository = new ServicoRepository();
        AluguelRepository aluguelRepository = new AluguelRepository();
        [HttpGet]
        public IActionResult Index()
        {
            AgendamentoViewModels avm = new AgendamentoViewModels();
            avm.Servicos = servicoRepository.ObterTodos();
            avm.Alugueis = aluguelRepository.ObterTodos();

            var emailCliente = ObterUsuarioSession();

            if(!string.IsNullOrEmpty(emailCliente))
            {
                clienteRepository.ObterPor(emailCliente);
            }
            var nomeUsuario = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuario))
            {
                avm.NomeCliente = nomeUsuario;
            }
            avm.NomeView = "Agendamento";
            avm.UsuarioEmail = emailCliente;
            avm.UsuarioNome = nomeUsuario;
            return View(avm);
        }
        [HttpPost]
            public IActionResult Registrar (IFormCollection form) 
            {
            ViewData["Action"] = "Agendamento";

            Agendamento agendamento = new Agendamento();
            string cnpj = form["cnpj"];
            agendamento.Cnpj = cnpj;

            string QuantidadePessoas = form["quantidadepessoas"];
            agendamento.QuantidadePessoas = QuantidadePessoas;

            var tipoEvento = form["tipoevento"];
            agendamento.TipoEvento = tipoEvento;

            var nomeAluguel = form["temaevento"];
            Aluguel aluguel = new Aluguel(
                nomeAluguel,
                aluguelRepository.ObterPrecoDe(nomeAluguel));
            
            agendamento.Aluguel = aluguel;

            var nomeServico = form["pacote"];
            Servico servico = new Servico(
                nomeServico, 
                servicoRepository.ObterPrecoDe(nomeServico));

            agendamento.Servicos = servico;

            Cliente cliente = new Cliente () {
                Nome = form["nome"],
                Telefone = form["telefone"],
                Email = form["email"]
            };

            agendamento.Cliente = cliente;

            agendamento.DataDoAgendamento = DateTime.Now;
            
            var dataEvento = DateTime.Parse(form["datadoevento"]);
            agendamento.DataDoEvento = dataEvento.ToShortDateString();

            agendamento.PrecoTotal = aluguel.Preco + servico.Preco;


            if (agendamentoRepository.Inserir (agendamento)) {
                return View ("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Mensagem",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                    
                });
            } else {
                return View ("Erro", new RespostaViewModel()
                {
                    NomeView = "Mensagem",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }


        public IActionResult Aprovar(ulong id, double PrecoAluguel)
        {
            var agendamento = agendamentoRepository.ObterPor(id);
            agendamento.Status = (uint) StatusAgendamento.APROVADO;

            if(agendamentoRepository.Atualizar(agendamento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel($"Não foi possível aprovar este evento!")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
        public IActionResult Reprovar(ulong id)
        {
            var data = agendamentoRepository.ObterPor(id);
            data.Status = (uint) StatusAgendamento.REPROVADO;

            if(agendamentoRepository.Atualizar(data))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession(),
                    UsuarioTipo = ObterUsuarioTipoSession()
                });
            }
        }
    }
}