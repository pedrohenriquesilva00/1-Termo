using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Controllers
{
    public class ClienteController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        private AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        [HttpGet]
        public IActionResult Login()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try 
            {
                System.Console.WriteLine("====================================");
                System.Console.WriteLine(form ["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("====================================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if(cliente != null)
                {
                    if(cliente.Senha.Equals(senha))
                    {
                        switch(cliente.TiposUsuario) 
                        {
                            case (uint) TiposUsuario.CLIENTE:
                            HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                            HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                            HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TiposUsuario.ToString());

                            return RedirectToAction("Historico", "Cliente");

                            default:
                            HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                            HttpContext.Session.SetString(SESSION_CLIENTE_NOME,cliente.Nome);
                            HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TiposUsuario.ToString());

                            return RedirectToAction("Dashboard", "Administrador");
                        }
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModel("Senha incorreta")
                        {
                            NomeView = "Erro",
                            UsuarioEmail = ObterUsuarioSession(),
                            UsuarioNome = ObterUsuarioNomeSession(),
                        });
                    }
                }
                else
                {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado")
                    {
                        NomeView = "Erro",
                        UsuarioEmail = ObterUsuarioSession(),
                        UsuarioNome = ObterUsuarioNomeSession(),
                    });
                }
            } 
            catch (Exception e) 
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel($"Erro")
                {
                        NomeView = "Erro",
                        UsuarioEmail = ObterUsuarioSession(),
                        UsuarioNome = ObterUsuarioNomeSession(),
                });
            }
        }
        public IActionResult Historico()
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var datasCliente = agendamentoRepository.ObterTodosPorCliente(emailCliente);
            return View(new HistoricoViewModel()
            {
                Evento = datasCliente,
                NomeView = "Historico",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}